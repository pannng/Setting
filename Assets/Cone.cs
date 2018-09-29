using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cone : MonoBehaviour {

	private float pointCanvas1;
    private float pointCone;
    private bool controlpanel;

    public GameObject cone;
    public GameObject canvas1;
    public GameObject canvas2;

    void Start()
    {
        cone.GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        pointCone = gameObject.transform.position.x;
        pointCanvas1 = canvas1.GetComponent<Transform>().position.z;
        controlpanel = canvas2.activeInHierarchy;


        if (pointCanvas1 - pointCone > 1 || controlpanel)
        {
            cone.GetComponent<Renderer>().enabled = true;
        }
        else
            cone.GetComponent<Renderer>().enabled = false;
        }

}
