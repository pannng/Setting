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
        presentRotationY = transform.eulerAngles.y;
    }

    void Update()
    {
        presentRotationY = transform.eulerAngles.y;

        if (CoolDownLeft > 0.0f)
        {
            CoolDownLeft -= Time.deltaTime;
            if (CoolDownLeft < 0.0F)
            {
                CoolDownLeft = 0.0F;
            }

        }

        if (presentRotationY > 179 && presentRotationY < 181 && CoolDownLeft <= 0.0F)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
