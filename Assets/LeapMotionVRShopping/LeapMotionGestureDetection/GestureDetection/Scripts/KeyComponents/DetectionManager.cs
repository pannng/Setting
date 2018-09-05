using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;


public enum ESpecificBone
{
    eBone0,
    eBone1,
    eBone2
}

public enum EHand
{
    eRightHand,
    eLeftHand
}

public enum EDirection
{
    eUpwards,
    eDownwards,
    eLeft,
    eRight,
    eOutwards,
    eInWards
}

public enum EHandAxis
{
    ePalmDirection,
    eThumbDirection,
    eFingerDirection
}


public enum EFinger
{
    eUnknown = -1,
    eThumb = 0,
    eIndex = 1,
    eMiddle = 2,
    eRing = 3,
    ePinky = 4
}


public struct FingerExtendedDetails
{
    public bool bThumbExtended;
    public bool bIndexExtended;
    public bool bMiddleExtended;
    public bool bRingExtended;
    public bool bPinkeyExtended;
}


partial class DetectionManager : MonoBehaviour
{
    public static DetectionManager sInstance = null;

    public GameObject m_ManipulatedObject;

    DetectionHand m_LeftDetection;

    DetectionHand m_RightDetection;

    LeapServiceProvider m_LeapService;


    //delegate  GetCurrentObj;
    //GetCurrentObj  getCurrentObj;


    int m_iNumberOfHands = 0;

    bool m_bLeftIsVisible = false;
    bool m_bRightIsVisible = false;

    GameObject m_LeftFingerCollision;
    GameObject m_RightFingerCollision;

    //Using Observer Pattern to get the manipulated object
    public delegate void GetCurrentObject(GameObject currentobj);
    public GetCurrentObject getCurrentObject; 


    public static DetectionManager Get()
    {
        return sInstance;
    }

    public void ChangeCurrentObject(GameObject gameObject)
    {
        m_ManipulatedObject = gameObject;
    }

    //public GameObject GetCurrentGameObject()
    //{
    //    if (m_ManipulatedObject != null)
    //    {
    //        return m_ManipulatedObject;
    //    }
     
    //        return null;
    //}

    public DetectionHand GetHand(EHand a_hand)
    {
        return a_hand == EHand.eRightHand ? m_RightDetection : m_LeftDetection;
    }

    public bool IsHandSet(EHand a_hand)
    {
        bool bIsVisible = a_hand == EHand.eLeftHand ? m_bLeftIsVisible : m_bRightIsVisible;
        return GetHand(a_hand).IsSet() && bIsVisible;
    }

    public bool IsBothHandsSet()
    {
        return IsHandSet(EHand.eLeftHand) && IsHandSet(EHand.eRightHand);
    }

    public bool AreBothHandsVisible()
    {
        return m_iNumberOfHands >= 2 && IsBothHandsSet();
    }

    public float GetDistanceBetweenHands()
    {
        Vector3 leftPos = m_LeftDetection.GetHandPosition();
        Vector3 rightPos = m_RightDetection.GetHandPosition();

        return Vector3.Distance(leftPos, rightPos);
    }

    public Transform GetLeapControllerTransform()
    {
        return m_LeapService.transform;
    }

    private void Awake()
    {
        if (sInstance == null)
        {
            sInstance = this;
        }
        else
        {
            Destroy(this);
        }

        m_LeftDetection = new DetectionHand();
        m_RightDetection = new DetectionHand();

        m_LeapService = FindObjectOfType<LeapServiceProvider>();

        m_LeftFingerCollision = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        m_RightFingerCollision = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        m_LeftFingerCollision.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        m_RightFingerCollision.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

        m_LeftFingerCollision.GetComponent<SphereCollider>().isTrigger = true;
        m_RightFingerCollision.GetComponent<SphereCollider>().isTrigger = true;

        m_RightFingerCollision.GetComponent<MeshRenderer>().enabled = false;
        m_LeftFingerCollision.GetComponent<MeshRenderer>().enabled = false;

        Rigidbody leftRigid = m_LeftFingerCollision.AddComponent<Rigidbody>();
        Rigidbody rightRigid = m_RightFingerCollision.AddComponent<Rigidbody>();

        rightRigid.useGravity = false;
        rightRigid.collisionDetectionMode = CollisionDetectionMode.Continuous;

        leftRigid.useGravity = false;
        leftRigid.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }

    void Start()
    {

    }

    void Update()
    {
        Frame frame = m_LeapService.CurrentFrame;
        bool bHasHandsInScene = frame.Hands.Count > 0;
        bool bControllerIsConnected = m_LeapService.IsConnected();

        m_iNumberOfHands = frame.Hands.Count;

        if (bHasHandsInScene && bControllerIsConnected)
        {
            foreach (Hand hand in frame.Hands)
            {
                if (hand.IsLeft)
                {
                    m_LeftDetection.SetHand(hand);

                    m_LeftFingerCollision.transform.position = m_LeftDetection.GetFinger(EFinger.eIndex).GetTipPosition();

                    m_bLeftIsVisible = true;

                    m_LeftFingerCollision.SetActive(true);

                    if (m_iNumberOfHands == 1)
                    {
                        m_bRightIsVisible = false;
                        m_RightFingerCollision.SetActive(false);
                    }
                }
                else
                {
                    m_RightDetection.SetHand(hand);

                    m_RightFingerCollision.transform.position = m_RightDetection.GetFinger(EFinger.eIndex).GetTipPosition();

                    m_bRightIsVisible = true;

                    m_RightFingerCollision.SetActive(true);

                    if (m_iNumberOfHands == 1)
                    {
                        m_bLeftIsVisible = false;
                        m_LeftFingerCollision.SetActive(false);
                    }
                }
            }
        }
    }
}
