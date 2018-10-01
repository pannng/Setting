using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCone : MonoBehaviour {

    private float pointCanvas;
    private float pointCone;

    public GameObject cone;
    public GameObject canvas;
 
    void Start()
    {
        cone.GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        pointCone = gameObject.transform.position.x;
        pointCanvas = canvas.GetComponent<Transform>().position.z;


        if (pointCanvas - pointCone > 1 )
        {
            cone.GetComponent<Renderer>().enabled = true;
        }
        else
            cone.GetComponent<Renderer>().enabled = false;
    }
}
