using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selections : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void TocolorA()
    {
        transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].color = Color.red;
    }

    public void TocolorB()
    {
        transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].color = Color.black;
    }

    public void TocolorC()
    {
        transform.GetChild(0).GetComponent<MeshRenderer>().materials[1].color = Color.green;
    }

    public void ToS()
    {
        transform.localScale = new Vector3(0.5F, 0.5F, 0.5F);
    }

    public void ToM()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }

    public void ToL()
    {
        transform.localScale = new Vector3(1.5F, 1.5F, 1.5F);
    }
}
