using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beep : MonoBehaviour {

    public AudioClip clip;

    public void BeepPlay()
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Delayshowthemenu()
    {
        Invoke("BeepPlay", 10);
    }

}
