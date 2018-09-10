using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selections : MonoBehaviour {

    public AudioClip clip;

    void Start () {
		
	}
	
	void Update () {
		
	}

    public void TocolorA()
    {
        transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].color = Color.red; //transform.GetComponent<MeshRenderer>().materials[1].color = Color.red;颜色变成红色
        AudioSource.PlayClipAtPoint(clip, transform.position); //音效
    }

    public void TocolorB()
    {
        transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].color = Color.blue;
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void TocolorC()
    {
        transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].color = Color.green;
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void ToS()
    {
        transform.localScale = new Vector3(0.5F, 0.5F, 0.5F); //transform.localScale = new Vector3(0.5F, 0.5F, 0.5F)
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void ToM()
    {
        transform.localScale = new Vector3(1, 1, 1);
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void ToL()
    {
        transform.localScale = new Vector3(1.5F, 1.5F, 1.5F);
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
