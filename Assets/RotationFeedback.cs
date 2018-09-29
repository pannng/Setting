using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap.Unity.Attributes;
using System;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Leap.Unity.Interaction;

public class RotationFeedback : MonoBehaviour {

    public float presentRotationY;

    public Button t4;
    public GameObject T4;

    public float CoolDownTime = 0.2F;
    float CoolDownLeft = 0.0F;

    public AudioClip clip;

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
            if (CoolDownLeft < 0.0F)
            {
                CoolDownLeft = 0.0F;
            }

        }

        if (presentRotationY > 0 && presentRotationY < 1 && presentRotationY < 360 && presentRotationY > 359 && CoolDownLeft <= 0.0F)
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
            InteractionButton T4InteractionButton = (InteractionButton)T4.GetComponent(typeof(InteractionButton));
            T4InteractionButton.controlEnabled = false;
            T4.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
            t4.interactable = false;
        }
    }
}
