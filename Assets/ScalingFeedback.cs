using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingFeedback : MonoBehaviour {

    public float presentScaleX;

    public AudioSource SoundComplete;

    void Start()
    {
        SoundComplete = GetComponent<AudioSource>();
        presentScaleX = transform.localScale.x;
    }

    void Update () {
        presentScaleX = transform.localScale.x;
        if (presentScaleX == 2)
        {
            SoundComplete.Play();
        }
    }
}
