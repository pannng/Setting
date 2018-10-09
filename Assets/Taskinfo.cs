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
        InteractionButton T1InteractionButton = (InteractionButton)T1.GetComponent(typeof(InteractionButton));
        T1InteractionButton.controlEnabled = false;
        T1.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
        t1.interactable = false;

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
        InteractionButton T2InteractionButton = (InteractionButton)T2.GetComponent(typeof(InteractionButton));
        T2InteractionButton.controlEnabled = false;
        T2.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
        t2.interactable = false;

        iftask1 = false;
        iftask2 = true;
        Bag.SetActive(true);
        Big.SetActive(true);

        TaskNum.text = "Task 2  Enlarge 放大";
        Taskc.text = "\n\n请放大红色背包至2倍大小，具体大小将由黄色框体提示\n（框体仅用于示意大小）\n\n放大成功时，您将听到提示音";
        Taske.text = "\nPlease enlarge the red bag to 2 times.\nThe target size is shown by the yellow frame.\n\nIf successful, you will hear a sound";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task3()
    {
        InteractionButton T3InteractionButton = (InteractionButton)T3.GetComponent(typeof(InteractionButton));
        T3InteractionButton.controlEnabled = false;
        T3.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
        t3.interactable = false;

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
        InteractionButton T4InteractionButton = (InteractionButton)T4.GetComponent(typeof(InteractionButton));
        T4InteractionButton.controlEnabled = false;
        T4.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
        t4.interactable = false;

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
        InteractionButton T5InteractionButton = (InteractionButton)T5.GetComponent(typeof(InteractionButton));
        T5InteractionButton.controlEnabled = false;
        T5.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
        t5.interactable = false;

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

        InteractionButton T6InteractionButton = (InteractionButton)T6.GetComponent(typeof(InteractionButton));
        T6InteractionButton.controlEnabled = false;
        T6.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
        t6.interactable = false;

        TaskNum.text = "Task 6  Close product details 关闭商品详情";
        Taskc.text = "\n请关闭商品详情页面";
        Taske.text = "\n\nPlease close product details";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task7()
    {
        InteractionButton T7InteractionButton = (InteractionButton)T7.GetComponent(typeof(InteractionButton));
        T7InteractionButton.controlEnabled = false;
        T7.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
        t7.interactable = false;

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
        InteractionButton T8InteractionButton = (InteractionButton)T8.GetComponent(typeof(InteractionButton));
        T8InteractionButton.controlEnabled = false;
        T8.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
        t8.interactable = false;

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
        InteractionButton T9InteractionButton = (InteractionButton)T9.GetComponent(typeof(InteractionButton));
        T9InteractionButton.controlEnabled = false;
        T9.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
        t9.interactable = false;

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
        InteractionButton T10InteractionButton = (InteractionButton)T10.GetComponent(typeof(InteractionButton));
        T10InteractionButton.controlEnabled = false;
        T10.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
        t10.interactable = false;

        iftask9 = false;
        iftask10 = true;
        Bag.transform.position = positionZero;
        Bag.transform.eulerAngles = rotationZero;
        Bag.transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].color = maryJane;
        Bag.transform.localScale = new Vector3(1F, 1F, 1F);
        Bag.SetActive(true);

        TaskNum.text = "Task 10  Add to cart 添加到购物车";
        Taskc.text = "\n请将背包加入购物车，购物车是您视野右上方的气泡\n\n加入购物车成功时，您将听到提示音，购物车变成红色";
        Taske.text = "\nPlease add the bag to the cart, the bubble on the top right of your view.\n\nIf successful, you will hear a sound and the cart will turn red.";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
