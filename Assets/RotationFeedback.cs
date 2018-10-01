using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap.Unity.Attributes;
using System;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Leap.Unity.Interaction;

public class RotationFeedback : MonoBehaviour
{

    public Taskinfo other;

    public float presentRotationY;

    //public Button t4;
    //public GameObject T4;

    public AudioClip clip;

    public Timer timer;

    public float CoolDownTime = 10f;
    float CoolDownLeft = 0.0f;





    void Start()
    {
        presentRotationY = transform.eulerAngles.y; //获取原始的角度
    }

    void Update()
    {
        presentRotationY = transform.eulerAngles.y; //更新的角度

        if (CoolDownLeft > 0.0f)
        {
            CoolDownLeft -= Time.deltaTime;
            if (CoolDownLeft < 0.0f)
            {
                CoolDownLeft = 0.0f;
            }

        }

        if (presentRotationY > 179 && presentRotationY < 181 && CoolDownLeft <= 0.0f && other.iftask4)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
            CoolDownLeft = CoolDownTime;

            //InteractionButton T4InteractionButton = (InteractionButton)T4.GetComponent(typeof(InteractionButton));
            //T4InteractionButton.controlEnabled = false;
            //T4.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
            //t4.interactable = false;
            timer.PauseTiming();
        }
    }
}
