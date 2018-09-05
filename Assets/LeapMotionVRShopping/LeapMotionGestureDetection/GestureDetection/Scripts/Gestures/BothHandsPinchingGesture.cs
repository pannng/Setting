using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BothHandsPinchingGesture : GestureBase
{
    public override bool Detected()
    {
        if (DetectionManager.Get().IsBothHandsSet() && DetectionManager.Get().AreBothHandsVisible())
        {
            bool bLeftHandPinching = DetectionManager.Get().GetHand(EHand.eLeftHand).IsPinching();
            bool bRightHandPinching = DetectionManager.Get().GetHand(EHand.eRightHand).IsPinching();

            return bLeftHandPinching && bRightHandPinching;
        }

        return false;
    }
}
