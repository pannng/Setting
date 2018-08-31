using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour {

    public Text BrandText;
    public Text ProductNameText;
    public Text GradeText;
    public Text ColorText;
    public Text CompositionText;
    public Text PriceText;

    public void ShowContent(string brand, string productname, string grade, string color, string composition, string price)
    {
        BrandText.text = brand;
        ProductNameText.text = productname;
        GradeText.text = grade;
        ColorText.text = color;
        CompositionText.text = composition;
        PriceText.text = price;

    }

}
