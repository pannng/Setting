using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class MenuManager : MonoBehaviour
{

    public GameObject m_object;
    public GameObject childobject;
    public Taskinfo other;
    //public GameObject T5;
    //public GameObject T6;
    public Timer timer;
    public AudioClip complete;


    void Start()
    {

        DetectionManager.Get().getCurrentObject += GetMenuObj;

    }


    void Update()
    {
        //m_object = DetectionManager.Get().GetCurrentGameObject();
        //childobject = m_object.transform.GetChild(0).gameObject;
    }

    public void GetMenuObj(GameObject currentobject)
    {
        m_object = currentobject;
        childobject = m_object.transform.GetChild(1).gameObject;
    }


    public void PresentingthisObjectMenu()
    {
        if (childobject != null)
        {
            if (!childobject.activeSelf)
            {
                childobject.SetActive(true);
                if (other.iftask5)
                {
                    //InteractionButton T5InteractionButton = (InteractionButton)T5.GetComponent(typeof(InteractionButton));
                    //T5InteractionButton.controlEnabled = false;
                    //T5.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
                    timer.PauseTiming();
                    AudioSource.PlayClipAtPoint(complete, transform.position);
                }
            }

            //Debug.Log("This childobject menu has been active!");
        }

    }

    public void HidethisObjectMenu()
    {
        if (childobject != null)
        {
            if (childobject.activeSelf)
            {
                childobject.SetActive(false);

                if (other.iftask6)
                {
                    //InteractionButton T6InteractionButton = (InteractionButton)T6.GetComponent(typeof(InteractionButton));
                    //T6InteractionButton.controlEnabled = false;
                    //T6.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
                    timer.PauseTiming();
                    AudioSource.PlayClipAtPoint(complete, transform.position);
                }
            }

            //Debug.Log("This childobject menu has been deactive!");
        }
    }
}
