using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap.Unity.Attributes;
using System;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Leap.Unity.Interaction;

public class ShoppingCart : MonoBehaviour
{

    public Taskinfo other;

    private Vector3 pointZero;
    private Vector3 pointCart;
    private Vector3 pointMove;
    public GameObject Cart;
    public Material red;

    public AudioClip clip;

    public float bigScale;
    public float smallScale;

    //public Button t10;
    //public GameObject T10;

    public Timer timer;
    //public float CoolDownTime = 10f;
    //float CoolDownLeft = 0.0f;

    void Start()
    {
        pointZero = transform.position;
    }

    public void Update()
    {
        pointMove = gameObject.transform.position;           //实时获取物体的位置
        pointCart = Cart.GetComponent<Transform>().position; //实时获取购物车的位置

        if (Vector3.Distance(transform.position, pointCart) < 0.5) //判断以上两个位置之间的距离
        {
            Cart.transform.localScale = new Vector3(bigScale, bigScale, bigScale); //购物车放大
            Cart.GetComponent<MeshRenderer>().materials[1] = red;
        }

        if (Vector3.Distance(transform.position, pointCart) < 0.1 && other.iftask10)
        {
            //CoolDownLeft = CoolDownTime;
            Cart.GetComponent<MeshRenderer>().materials[1].SetColor("_TintColor", Color.red);
            gameObject.SetActive(false);                                     //销毁物体
            AudioSource.PlayClipAtPoint(clip, transform.position);   //音效

            //InteractionButton T10InteractionButton = (InteractionButton)T10.GetComponent(typeof(InteractionButton));
            //T10InteractionButton.controlEnabled = false;
            //T10.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
            //t10.interactable = false;
            timer.PauseTiming();
        }



        if (Vector3.Distance(transform.position, pointCart) > 0.5)
        {
            Cart.transform.localScale = new Vector3(smallScale, smallScale, smallScale); //距离远，购物车缩小
            Cart.GetComponent<MeshRenderer>().materials[1] = red;
        }
    }
}
