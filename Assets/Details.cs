using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Detailes : MonoBehaviour
{

    public string brand;
    public string productname;
    public string grade;
    public string color;
    public string composition;
    public float price;

    public GameObject DetailMenu;

    private VRTK_ControllerEvents controllerEvents;

    private void Start()
    {
        controllerEvents = GetComponent<VRTK_ControllerEvents>();
        controllerEvents.GripClicked += DoGripClicked;

    }

    private void DoGripClicked(object sender, ControllerInteractionEventArgs e)
    {
        DetailMenu.gameObject.SetActive(true);
        GameObject.FindWithTag("boom").GetComponent<Panel>().ShowContent(brand, productname, grade, color, composition, price.ToString());
    }

}

