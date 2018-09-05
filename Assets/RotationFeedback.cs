using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationFeedback : MonoBehaviour {

    public float presentRotationX;
    
    public AudioSource SoundComplete;

    void Start()
    {
        SoundComplete = GetComponent<AudioSource>();
        presentRotationX = transform.eulerAngles.x;
    }

    void Update()
    {
        presentRotationX = transform.eulerAngles.x;
        if (System.Math.Abs(presentRotationX) == 180)
        {
            SoundComplete.Play();
        }
    }
}
