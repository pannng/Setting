using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeObject : MonoBehaviour
{
    public GameObject m_object;
    //public GameObject m2_Object;
    public float m_Scalar;

    float m_fLastDist;

    bool m_bResizing = false;

    void Start()
    {
        DetectionManager.Get().getCurrentObject += GetResizeObj;

    }

    void Update()
    {
       //m_object = DetectionManager.Get().GetCurrentGameObject();

        if (m_bResizing && DetectionManager.Get().IsBothHandsSet())
        {
            float fNewDistance = GetDistance();

            float fChange = fNewDistance - m_fLastDist;
            
            m_object.transform.localScale += new Vector3(fChange, fChange, fChange) * m_Scalar;
            
            if(m_object.transform.localScale.x < 0)
            {
                m_object.transform.localScale = new Vector3(0, 0, 0);
            }

            m_fLastDist = fNewDistance;
        }
    }

    public void GetResizeObj(GameObject currentobject)
    {
        m_object = currentobject;
    }

    float GetDistance()
    {
        Vector3 pos1 = DetectionManager.Get().GetHand(EHand.eLeftHand).GetFinger(EFinger.eIndex).GetTipPosition();
        Vector3 pos2 = DetectionManager.Get().GetHand(EHand.eRightHand).GetFinger(EFinger.eIndex).GetTipPosition();
        return Vector3.Distance(pos1, pos2);
    }

    public void StartResize()
    {
        m_fLastDist = GetDistance();
        m_bResizing = true;
    }

    public void EndResize()
    {
        m_bResizing = false;
    }

}
