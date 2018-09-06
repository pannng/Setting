using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationFeedback : MonoBehaviour {

    public float presentRotationY;
    
    public AudioClip clip;

    void Start()
    {
        presentRotationY = transform.eulerAngles.y;
    }

    void Update()
    {
        presentRotationY = transform.eulerAngles.y;
        if (presentRotationY > 170 && presentRotationY < 190)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
