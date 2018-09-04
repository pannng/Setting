using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingFeedback : MonoBehaviour {

    public float doubleScale;
    public float presentScaleX;
    public float presentScaleY;
    public float presentScaleZ;

    AudioSource SoundComplete;

    private void Start()
    {
        SoundComplete = GetComponent<AudioSource>();
        presentScaleX = transform.localScale.x;
        presentScaleY = transform.localScale.y;
        presentScaleZ = transform.localScale.z;
    }

    void Update () {
        presentScaleX = transform.localScale.x;
        presentScaleY = transform.localScale.y;
        presentScaleZ = transform.localScale.z;
        if (presentScaleX == doubleScale && presentScaleY == doubleScale && presentScaleZ == doubleScale)
        {
            SoundComplete.Play();
        }
    }
}
