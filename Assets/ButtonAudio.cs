using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour {

    public AudioClip m_buttonAudio;

	void Start () {
		
	}
	

	void Update () {
		
	}

    public void PlayButtonAudio()
    {
        AudioSource.PlayClipAtPoint(m_buttonAudio, transform.position);
    }
}
