using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour {

    public GameObject controlPanel;
    public GameObject star;

    void Start()
    {
        controlPanel.SetActive(false);
        //star.SetActive(false);
    }

    public void OpenPanel()
    {
        controlPanel.SetActive(true);
        //star.SetActive(true);
    }

    public void ClosePanel()
    {
        controlPanel.SetActive(false);
        //star.SetActive(false);
    }
}
