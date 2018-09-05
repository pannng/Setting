using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour {

    public GameObject controlPanel;

    void Start()
    {
        controlPanel.SetActive(false);
    }

    public void OpenPanel()
    {
        controlPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        controlPanel.SetActive(false);
    }
}
