using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingFeedback : MonoBehaviour {

    public float presentScaleX;

    public AudioClip clip;

    void Start()
    {
        presentScaleX = transform.localScale.x;
    }

    void Update () {
        presentScaleX = transform.localScale.x;
        if (presentScaleX > 1.99 && presentScaleX < 2.01)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
