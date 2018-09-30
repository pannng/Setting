using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap.Unity.Attributes;
using System;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Leap.Unity.Interaction;

public class TryingOn : MonoBehaviour
{

    private Vector3 pointZero;
    private Vector3 pointBody;
    private Vector3 pointMove;
    public GameObject Body;

    public Button t9;
    public GameObject T9;

    public AudioClip clip;

    public Taskinfo other;

    public Timer timer;

    void Start()
    {
        pointZero = transform.position;
    }

    public void Update()
    {
        pointMove = gameObject.transform.position;           //实时获取物体的位置
        pointBody = Body.GetComponent<Transform>().position; //实时获取购物车的位置

        if (Vector3.Distance(transform.position, pointBody) < 0.3 && other.iftask9)
        {
            gameObject.SetActive(false);                                     //销毁物体
            AudioSource.PlayClipAtPoint(clip, transform.position);   //音效

            InteractionButton T9InteractionButton = (InteractionButton)T9.GetComponent(typeof(InteractionButton));
            T9InteractionButton.controlEnabled = false;
            T9.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
            t9.interactable = false;
            timer.PauseTiming();
        }
    }
}
