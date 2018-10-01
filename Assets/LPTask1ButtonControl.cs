using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using Leap.Unity.Interaction;

public class LPTask1ButtonControl : MonoBehaviour
{

    public Taskinfo taskInfo;
    public GameObject T1;
    public Timer timer;
    private GameObject m_currentObject;
    public AudioClip clip;


    private void Start()
    {
        DetectionManager.Get().getCurrentObject += Task1ButtonControl;
    }

    public void Task1ButtonControl(GameObject currentobject)
    {
        m_currentObject = currentobject;
        if (taskInfo.iftask1)
        {
            InteractionButton T1InteractionButton = (InteractionButton)T1.GetComponent(typeof(InteractionButton));
            T1InteractionButton.controlEnabled = false;
            T1.transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().materials[0].color = Color.grey;
            AudioSource.PlayClipAtPoint(clip, transform.position);
            timer.PauseTiming();
        }
    }




}
