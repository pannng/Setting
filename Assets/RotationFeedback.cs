using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationFeedback : MonoBehaviour {

    public float presentRotationY;

    public float CoolDownTime = 0.2F;
    float CoolDownLeft = 0.0F;

    public AudioClip clip;

    void Start()
    {
        presentRotationY = transform.eulerAngles.y; //获取原始的角度
    }

    void Update()
    {
        presentRotationY = transform.eulerAngles.y; //更新的角度

        if (CoolDownLeft > 0.0f)
        {
            CoolDownLeft -= Time.deltaTime;
            if (CoolDownLeft < 0.0F)
            {
                CoolDownLeft = 0.0F;
            }

        }

        if (presentRotationY > 0 && presentRotationY < 1 && presentRotationY < 360 && presentRotationY > 359 && CoolDownLeft <= 0.0F)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
