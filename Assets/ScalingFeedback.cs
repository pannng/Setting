using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap.Unity.Attributes;
using System;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Leap.Unity.Interaction;

public class ScalingFeedback : MonoBehaviour {

    public float presentScaleX;
    public GameObject Big;
    public GameObject Small;
    public GameObject Origin;

    public Button t2;
    public Button t3;
    public GameObject T2;
    public GameObject T3;

    public float CoolDownTime = 0.2F;
    float CoolDownLeft = 0.0F;

    public AudioClip clip;  //创建一个音效

    void Start()
    {
        presentScaleX = transform.localScale.x; //开始的时候获取原始尺寸
        Big.SetActive(false);
        Small.SetActive(false);
        Origin.SetActive(false);
    }

    void Update () {
        presentScaleX = transform.localScale.x; //每时每刻都获取物体的尺寸

        if (CoolDownLeft > 0.0f)
        {
            CoolDownLeft -= Time.deltaTime;
            if (CoolDownLeft < 0.0F)
            {
                CoolDownLeft = 0.0F;
            }

        }

        if (presentScaleX > 1.99 && presentScaleX < 2.01 && CoolDownLeft <= 0.0F) //尺寸接近2倍的时候，播放音效
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
            Big.SetActive(false);

            InteractionButton T2InteractionButton = (InteractionButton)T2.GetComponent(typeof(InteractionButton));
            T2InteractionButton.controlEnabled = false;
            T2.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
            t2.interactable = false;
        }

        if (presentScaleX > 1.01 && presentScaleX < 1.03 && CoolDownLeft <= 0.0F) //尺寸接近1倍的时候，播放音效
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
            Origin.SetActive(false);

            InteractionButton T3InteractionButton = (InteractionButton)T3.GetComponent(typeof(InteractionButton));
            T3InteractionButton.controlEnabled = false;
            T3.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
            t3.interactable = false;

        }
    }
}
