using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap.Unity.Attributes;
using System;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Leap.Unity.Interaction;

public class Selections : MonoBehaviour {

    public AudioClip clip;
    public Button t7;
    public Button t8;
    public GameObject T7;
    public GameObject T8;

    public Taskinfo other;

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

        if (other.iftask7)
        {
            t7.interactable = false;
        }
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

        if (other.iftask8)
        {
            t8.interactable = false;
        }
    }
}
