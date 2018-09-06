using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour {

    public enum ManipulatedObjectColor
    {
        Red,
        Blue,
        Green
    }

    GameObject m_object;
    GameObject childobject;
    Renderer rend;


	// Use this for initialization
	void Start () 
    {
        DetectionManager.Get().getCurrentObject += GetColorObj;
            //DetectionManager.Get().getCurrentObj += GetColorObj;
    }


    // Update is called once per frame
	void Update () 
    {
      
        //m_object = DetectionManager.Get().GetCurrentGameObject();
        //rend = m_object.GetComponent<Renderer>();
    }

    public void GetColorObj(GameObject currentobject)
    {

        //rend = m_object.GetComponent<Renderer>();
        m_object = currentobject;
        childobject = m_object.transform.GetChild(0).gameObject;
        rend = childobject.GetComponent<Renderer>();
    }

    public void ChangetoRedColor()
    {
        rend.materials[1].color = Color.red;
    }

    public void ChangetoGreenColor()
    {
        rend.materials[1].color = Color.green;
    }

    public void ChangetoBlueColor()
    {
        rend.materials[1].color = Color.blue;
    }


}
