using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchanger : MonoBehaviour {

    private readonly Color[] colors =
        {
        Color.black,
        Color.blue,
        Color.cyan
        
    };

    public void UpdateGridLayoutValue(int selectedIndex)
    {
        transform.GetChild(1).GetComponent<MeshRenderer>().materials[0].color = colors[selectedIndex];
    }

}
