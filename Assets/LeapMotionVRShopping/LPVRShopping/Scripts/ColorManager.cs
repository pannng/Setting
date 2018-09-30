using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Attributes;
using System;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Leap.Unity.Interaction;

public class ColorManager : MonoBehaviour
{

    public enum ManipulatedObjectColor
    {
        Red,
        Blue,
        Green
    }

    GameObject m_object;
    GameObject childobject;
    public GameObject T7;
    public Taskinfo other;
    Renderer rend;

    public Timer timer;


    // Use this for initialization
    void Start()
    {
        DetectionManager.Get().getCurrentObject += GetColorObj;
        //DetectionManager.Get().getCurrentObj += GetColorObj;
    }


    // Update is called once per frame
    void Update()
    {

        //m_object = DetectionManager.Get().GetCurrentGameObject();
        //rend = m_object.GetComponent<Renderer>();
    }

    public void GetColorObj(GameObject currentobject)
    {

        //rend = m_object.GetComponent<Renderer>();
        m_object = currentobject;
        childobject = m_object.transform.GetChild(0).gameObject;
        rend = childobject.GetComponent<Renderer>();
    }

    public void ChangetoRedColor()
    {
        rend.materials[1].color = Color.red;
    }

    public void ChangetoGreenColor()
    {
        rend.materials[1].color = Color.green;
        if (other.iftask7)
        {
            InteractionButton T7InteractionButton = (InteractionButton)T7.GetComponent(typeof(InteractionButton));
            T7InteractionButton.controlEnabled = false;
            T7.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
            timer.PauseTiming();
        }
    }

    public void ChangetoBlueColor()
    {
        rend.materials[1].color = Color.blue;
    }


}
