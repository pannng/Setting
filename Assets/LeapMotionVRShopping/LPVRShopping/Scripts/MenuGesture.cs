using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGesture : GestureBase
{
    public EHand m_Hand;
    public EHandAxis m_HandAxis;
    public EDirection m_Direction;
    public float m_TimeRange = 1f;

    float m_CoolDownLeft = 0.0f;
    bool m_IsFist = false;

    [Range(0.0f, 1.0f)]
    public float m_ClosedPercentage = 0.6f;

    Dictionary<EDirection, Vector3> m_DirectionMap = new Dictionary<EDirection, Vector3>();

    void Start ()
    {
        m_DirectionMap.Add(EDirection.eUpwards, Vector3.up);
        m_DirectionMap.Add(EDirection.eDownwards, Vector3.down);
        m_DirectionMap.Add(EDirection.eLeft, Vector3.left);
        m_DirectionMap.Add(EDirection.eRight, Vector3.right);
        m_DirectionMap.Add(EDirection.eInWards, Vector3.back);
        m_DirectionMap.Add(EDirection.eOutwards, Vector3.forward);
    }
	

	void Update () 
    {
        if (m_CoolDownLeft > 0.0f)
        {
            m_CoolDownLeft -= Time.deltaTime;
            if (m_CoolDownLeft < 0.0f)
            {
                m_CoolDownLeft = 0.0f;
            }
        }

    }

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

    void IsFist()
    {
        if (DetectionManager.Get().IsHandSet(m_Hand))
        {
            if(DetectionManager.Get().GetHand(m_Hand).IsClosed(m_ClosedPercentage)) 
            {
                m_CoolDownLeft = m_TimeRange;
                m_IsFist = true;
                Debug.Log("Detect the first phase of MenuGesture-Fist");
            }
            //return DetectionManager.Get().GetHand(m_Hand).IsClosed(m_ClosedPercentage);
        }

        m_IsFist = false;
    }


    public override bool Detected()
    {
        bool bFound = false;
        EDirection currentDirection = GetClosestDirection(ref bFound);

        IsFist();

        if (bFound && m_IsFist && m_CoolDownLeft > 0.0f)
        {
            if(currentDirection == m_Direction)
            {
                m_IsFist = false;
                Debug.Log("Detect the second phase of MenuGesture-HandOn");
                return true;
            }

            m_IsFist = false;

        }
        m_IsFist = false;
        return false;
    }


}
