using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGesture : GestureBase
{
    public EHand m_Hand;
    public EHandAxis m_HandAxis;
    public EDirection m_Direction;
    bool alreadyFist = false;

    //Sequence Gesture
    public float m_TimeRange = 2f;

    FingerExtendedDetails m_GestureDetail;
    [Range(0.0f, 1.0f)]
    public float m_ClosedPercentage = 0.6f;

    float m_CoolDownLeft = 0.0f;
    bool m_IsFist = false;
    bool m_IsHandAllExtended = false;

    //public MenuManager m_menumanager;




    Dictionary<EDirection, Vector3> m_DirectionMap = new Dictionary<EDirection, Vector3>();

    void Start ()
    {   //For hand direction
        m_DirectionMap.Add(EDirection.eUpwards, Vector3.up);
        m_DirectionMap.Add(EDirection.eDownwards, Vector3.down);
        m_DirectionMap.Add(EDirection.eLeft, Vector3.left);
        m_DirectionMap.Add(EDirection.eRight, Vector3.right);
        m_DirectionMap.Add(EDirection.eInWards, Vector3.back);
        m_DirectionMap.Add(EDirection.eOutwards, Vector3.forward);

        //For hand extended
        m_GestureDetail.bThumbExtended = true;
        m_GestureDetail.bIndexExtended = true;
        m_GestureDetail.bMiddleExtended = true;
        m_GestureDetail.bRingExtended = true;
        m_GestureDetail.bPinkeyExtended = true;
    }
	
    //Set a Timer
	void Update () 
    {
        if (m_CoolDownLeft > 0.0f)
        {
            m_CoolDownLeft -= Time.deltaTime;
            if (m_CoolDownLeft < 0.0f)
            {
                m_CoolDownLeft = 0.0f;
                alreadyFist = false;
                m_IsHandAllExtended = false;

            }
        }

    }

    //Get the current hand direction
    EDirection GetClosestDirection(ref bool a_bDetected)
    {
        DetectionManager.DetectionHand detectionHand = DetectionManager.Get().GetHand(m_Hand);

        if (!detectionHand.IsSet())
        {
            a_bDetected = false;
            return EDirection.eDownwards;
        }

        Vector3 handDirection = detectionHand.GetHandAxis(m_HandAxis);

        float currentDistance = float.MaxValue;
        EDirection currentDir = EDirection.eUpwards;

        foreach (EDirection dir in m_DirectionMap.Keys)
        {
            float newDistance = Vector3.Distance(handDirection, m_DirectionMap[dir]);

            if (newDistance < currentDistance)
            {
                currentDistance = newDistance;
                currentDir = dir;
                a_bDetected = true;
            }
        }

        return currentDir;
    }

    //Phase 1 -- Fist hand
    //Decide whether is Fist or not
    void IsFist()
    {
        if (DetectionManager.Get().IsHandSet(m_Hand))
        {
            if(DetectionManager.Get().GetHand(m_Hand).IsClosed(m_ClosedPercentage)) 
            {
                m_CoolDownLeft = m_TimeRange;
                m_IsFist = true;
                alreadyFist = true;
                //Debug.Log("Detect the first phase of MenuGesture-Fist");
                m_IsHandAllExtended = false;
                return;
            }
            //return DetectionManager.Get().GetHand(m_Hand).IsClosed(m_ClosedPercentage);
        }

    }

    void IsHandAllExtended()
    {
        DetectionManager.DetectionHand detectHand = DetectionManager.Get().GetHand(m_Hand);

        if (detectHand.IsSet())
        {
            if(detectHand.CheckWithDetails(m_GestureDetail))
            {
                m_IsHandAllExtended = true;
                Debug.Log("success");
                //m_menumanager.PresentingthisObjectMenu();
                alreadyFist = false;
                //reset
                return;
            }
        }
        //m_IsHandAllExtended = false;
    }

    //Phase 2 -- Hand open upwards
    //if hand has fisted 
    //if it is still in the time range 
    //if the hand direction matches
    public override bool Detected()
    {
        bool bFound = false;
        EDirection currentDirection = GetClosestDirection(ref bFound);

        if (!alreadyFist){
            IsFist();
        }else{
            if (bFound && m_CoolDownLeft > 0.0f)
            {
                if (currentDirection == m_Direction)
                {

                    IsHandAllExtended();
                }

            }
        }

        return m_IsHandAllExtended;
        //IsFist();
    }


}
