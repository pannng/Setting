using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Clothes : MonoBehaviour
{

    public string brand;
    public string productname;
    public string grade;
    public string color;
    public string composition;
    public string price;

    private void Start()
    {
    GameObject.FindWithTag("boom").GetComponent<Panel>().ShowContent(brand, productname, grade, color, composition, price);
    }

}

