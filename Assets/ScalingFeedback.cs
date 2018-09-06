using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingFeedback : MonoBehaviour {

    public float presentScaleX;

    public float CoolDownTime = 0.2F;
    float CoolDownLeft = 0.0F;

    public AudioClip clip;

    void Start()
    {
        presentScaleX = transform.localScale.x;
    }

    void Update () {
        presentScaleX = transform.localScale.x;

        if (CoolDownLeft > 0.0f)
        {
            CoolDownLeft -= Time.deltaTime;
            if (CoolDownLeft < 0.0F)
            {
                CoolDownLeft = 0.0F;
            }

        }

        if (presentScaleX > 1.99 && presentScaleX < 2.01 && CoolDownLeft <= 0.0F)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
