using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Leap.Unity.Attributes;
using System;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Leap.Unity.Interaction;
using VRTK;


public class Taskinfo : MonoBehaviour {

    public VRTK_PanelMenuController other;
    public Text TaskNum;
    public Text Taskc;
    public Text Taske;
    public Vector3 positionZero;
    public Vector3 rotationZero;

    public GameObject biaoqian;
    public GameObject Big;
    public GameObject Origin;
    public GameObject Bag;
    public GameObject Detail;
    public Color maryJane;

    public bool iftask1;
    public bool iftask2;
    public bool iftask3;
    public bool iftask4;
    public bool iftask5;
    public bool iftask6;
    public bool iftask7;
    public bool iftask8;
    public bool iftask9;
    public bool iftask10;

    public AudioClip clip;

    public void Start()
    {
        maryJane = Bag.transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].color;
        positionZero = Bag.transform.position;
        iftask1 = false;
        iftask2 = false;
        iftask3 = false;
        iftask4 = false;
        iftask5 = false;
        iftask6 = false;
        iftask7 = false;
        iftask8 = false;
        iftask9 = false;
        iftask10 = false;
    }

    public void Task1() {
        biaoqian.SetActive(false);
        iftask1 = true;
        Bag.SetActive(true);
        TaskNum.text = "Task 1  Grab 抓取";
        Taskc.text = "\n请抓取红色背包\n\n抓取成功时，背包将跟随您移动";
        Taske.text = "\nPlease grab the red bag.\n\nIf successful, the bag will follow you.";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task2()
    {
        iftask1 = false;
        iftask2 = true;
        Bag.SetActive(true);
        Big.SetActive(true);
        TaskNum.text = "Task 2  Enlarge 放大";
        Taskc.text = "\n\n请放大红色背包至2倍大小，具体大小将由黄色框体提示\n\n放大成功时，您将听到提示音";
        Taske.text = "\nPlease enlarge the red bag to 2 times.\nThe target size is shown by the yellow frame.\n\nIf successful, you will hear a sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task3()
    {
        iftask2 = false;
        iftask3 = true;
        Bag.SetActive(true);
        Origin.SetActive(true);
        TaskNum.text = "Task 3  Shrink 缩小";
        Taskc.text = "\n\n请将红色背包还原至原来大小，具体大小由黄色框体提示\n\n缩小成功时，您将听到提示音";
        Taske.text = "\nPlease shrink the red bag to the original size.\nThe target size is shown by the yellow frame.\n\nIf successful, you will hear a sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task4()
    {
        iftask3 = false;
        iftask4 = true;
        Bag.SetActive(true);
        TaskNum.text = "Task 4  Rotate 旋转";
        Taskc.text = "\n\n请将红色背包旋转180度，使它背向您\n\n旋转成功时，您将听到提示音";
        Taske.text = "\nPlease rotate the red bag 180 degrees, making the bag back to you.\n\nIf successful, you will hear a sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task5()
    {
        Bag.transform.position = positionZero;
        Bag.transform.eulerAngles = rotationZero;
        iftask4 = false;
        iftask5 = true;
        Bag.SetActive(true);
        TaskNum.text = "Task 5  View product details 查看商品详情";
        Taskc.text = "\n请打开商品详情页面";
        Taske.text = "\n\nPlease view product details";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void ShowtheMenu()
    {
        other.ShowMenu();
    }

    public void Task6()
    {      
        iftask5 = false;
        iftask6 = true;
        Bag.SetActive(true);
        TaskNum.text = "Task 6  Close product details 关闭商品详情";
        Taskc.text = "\n请关闭商品详情页面";
        Taske.text = "\n\nPlease close product details";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task7()
    {
        iftask6 = false;
        iftask7 = true;
        Bag.SetActive(true);
        TaskNum.text = "Task 7  Change color 改变颜色";
        Taskc.text = "\n\n请依次改变背包的颜色为红，蓝，绿\n\n选择成功时，您将听到提示音";
        Taske.text = "\nPlease change the color of bag \nin the order of RED, BLUE and GREEN.\n\nIf successful, you will hear a button sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task8()
    {
        iftask7 = false;
        iftask8 = true;
        Bag.SetActive(true);
        Bag.transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].color = maryJane;
        TaskNum.text = "Task 8  Change size 改变尺码";
        Taskc.text = "\n\n请依次改变背包的大小为S，M，L\n\n选择成功时，您将听到提示音";
        Taske.text = "\nPlease change the size of bag \nin the order of S, M and L.\n\nIf successful, you will hear a button sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task9()
    {
        iftask8 = false;
        iftask9 = true;
        Bag.SetActive(true);
        Bag.transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].color = maryJane;
        Bag.transform.localScale = new Vector3(1F, 1F, 1F);
        TaskNum.text = "Task 9  Try on bag 试衣服";
        Taskc.text = "\n请试穿背包效果\n\n试穿成功时，您将听到提示音";
        Taske.text = "\nPlease try on the bag.\n\nIf successful, you will hear a sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task10()
    {
        iftask9 = false;
        iftask10 = true;
        Bag.transform.position = positionZero;
        Bag.transform.eulerAngles = rotationZero;
        Bag.transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].color = maryJane;
        Bag.transform.localScale = new Vector3(1F, 1F, 1F);
        Bag.SetActive(true);
        TaskNum.text = "Task 10  Add to cart 添加到购物车";
        Taskc.text = "\n请将背包加入购物车\n\n加入购物车成功时，您将听到提示音";
        Taske.text = "\nPlease add the bag to the cart.\n\nIf successful, you will hear a sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
