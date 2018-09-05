using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandFacingGesture : GestureBase
{
    public EHand m_Hand;
    public EHandAxis m_HandAxis;
    public EDirection m_Direction;

    Dictionary<EDirection, Vector3> m_DirectionMap = new Dictionary<EDirection, Vector3>();

    void Start()
    {
        m_DirectionMap.Add(EDirection.eUpwards, Vector3.up);
        m_DirectionMap.Add(EDirection.eDownwards, Vector3.down);
        m_DirectionMap.Add(EDirection.eLeft, Vector3.left);
        m_DirectionMap.Add(EDirection.eRight, Vector3.right);
        m_DirectionMap.Add(EDirection.eInWards, Vector3.back);
        m_DirectionMap.Add(EDirection.eOutwards, Vector3.forward);
    }

    void Update()
    {

    }

    EDirection GetClosestDirection(ref bool a_bDetected)
    {
        DetectionManager.DetectionHand detectionHand = DetectionManager.Get().GetHand(m_Hand);

        if(!detectionHand.IsSet())
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

    public override bool Detected()
    {
        bool bFound = false;
        EDirection currentDirection = GetClosestDirection(ref bFound);

        if(bFound)
        {
            return currentDirection == m_Direction;
        }

        return false;
    }
}
