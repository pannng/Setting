using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap.Unity.Attributes;
using System;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Leap.Unity.Interaction;


public class Taskinfo : MonoBehaviour {

    public Text TaskNum;
    public Text Taskc;
    public Text Taske;
    public Button t1;
    public Button t2;
    public Button t3;
    public Button t4;
    public Button t5;
    public Button t6;
    public Button t7;
    public Button t8;
    public Button t9;
    public Button t10;

    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject T4;
    public GameObject T5;
    public GameObject T6;
    public GameObject T7;
    public GameObject T8;
    public GameObject T9;
    public GameObject T10;

    public GameObject Big;
    public GameObject Bag;

    public AudioClip clip;

    public void Task1 () {
        Bag.SetActive(true);
        TaskNum.text = "Task 1  Grab 抓取";
        Taskc.text = "\n请抓取红色背包\n\n抓取成功时，背包将跟随您移动";
        Taske.text = "\nPlease grab the red bag.\n\nIf successful, the bag will follow you.";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task2()
    {
        InteractionButton T1InteractionButton = (InteractionButton)T1.GetComponent(typeof(InteractionButton));
        T1InteractionButton.controlEnabled = false;
        T1.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
        t1.interactable = false;
        Bag.SetActive(true);
        Big.SetActive(true);
        TaskNum.text = "Task 2  Enlarge 放大";
        Taskc.text = "\n\n请放大红色背包至2倍大小，具体大小将由黄色框体提示\n\n放大成功时，您将听到提示音";
        Taske.text = "\nPlease enlarge the red bag to 2 times.\nThe target size is shown by the yellow frame.\n\nIf successful, you will hear a sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task3()
    {
        t2.interactable = false;
        Bag.SetActive(true);
        Big.SetActive(true);
        TaskNum.text = "Task 3  Shrink 缩小";
        Taskc.text = "\n\n请将红色背包还原至原来大小，具体大小由黄色框体提示\n\n缩小成功时，您将听到提示音";
        Taske.text = "\nPlease shrink the red bag to the original size.\nThe target size is shown by the yellow frame.\n\nIf successful, you will hear a sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task4()
    {
        t3.interactable = false;
        Bag.SetActive(true);
        TaskNum.text = "Task 4  Rotate 旋转";
        Taskc.text = "\n\n请将红色背包旋转180度，使它背向您\n\n旋转成功时，您将听到提示音";
        Taske.text = "\nPlease rotate the red bag 180 degrees, making the bag back to you.\n\nIf successful, you will hear a sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task5()
    {
        t4.interactable = false;
        Bag.SetActive(true);
        TaskNum.text = "Task 5  View product details 查看商品详情";
        Taskc.text = "\n请打开商品详情页面";
        Taske.text = "\n\nPlease view product details";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task6()
    {
        t5.interactable = false;
        Bag.SetActive(true);
        TaskNum.text = "Task 6  Close product details 关闭商品详情";
        Taskc.text = "\n请关闭商品详情页面";
        Taske.text = "\n\nPlease close product details";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task7()
    {
        t6.interactable = false;
        Bag.SetActive(true);
        TaskNum.text = "Task 7  Change color 改变颜色";
        Taskc.text = "\n\n请依次改变背包的颜色为红，蓝，绿\n\n选择成功时，您将听到按键音";
        Taske.text = "\nPlease change the color of bag \nin the order of RED, BLUE and GREEN.\n\nIf successful, you will hear a button sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task8()
    {
        t7.interactable = false;
        Bag.SetActive(true);
        TaskNum.text = "Task 8  Change size 改变尺码";
        Taskc.text = "\n\n请依次改变背包的大小为S，M，L\n\n选择成功时，您将听到按键音";
        Taske.text = "\nPlease change the size of bag \nin the order of S, M and L.\n\nIf successful, you will hear a button sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task9()
    {
        t8.interactable = false;
        Bag.SetActive(true);
        TaskNum.text = "Task 9  Try on bag 试衣服";
        Taskc.text = "\n请试穿背包效果\n\n试穿成功时，您将听到提示音";
        Taske.text = "\nPlease try on the bag.\n\nIf successful, you will hear a sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task10()
    {
        t9.interactable = false;
        Bag.SetActive(true);
        TaskNum.text = "Task 10  Add to cart 添加到购物车";
        Taskc.text = "\n请将背包加入购物车\n\n加入购物车成功时，您将听到提示音";
        Taske.text = "\nPlease add the bag to the cart.\n\nIf successful, you will hear a sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
