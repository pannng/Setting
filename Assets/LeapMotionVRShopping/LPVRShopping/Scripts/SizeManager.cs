using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeManager : MonoBehaviour {

    public enum ManipulatedObjectSize
    {
        Small,
        Medium,
        Large
    }

    GameObject m_object;
    GameObject originalObject;

    Vector3 originalScale;

    ManipulatedObjectSize currentSizeState = ManipulatedObjectSize.Medium;

    //  bool isOtherObject = false;
    void Start()
    {
        DetectionManager.Get().getCurrentObject += GetSizeObj;
    }



    void Update()
    {
        //If the manipulated object is initializing...
        //save this object to originalObject

        //if (m_object == null)


        //   originalObject = m_object;
        //   originalScale = m_object.transform.localScale;


        //If the manipulated object has changed 
        //update this object to originalobject
        //m_object = DetectionManager.Get().GetCurrentGameObject();

        if (m_object != null && (m_object != originalObject))
        {
            originalScale = m_object.transform.localScale;
            originalObject = m_object;
        }

        ////int a = 5;
        ////int b = 6;
        ////a = b;->  a.value = b.value

        //GameObject c = null;  
        //GameObject a = null;
        //GameObject b = null;

        ////c->C
        ////a->A
        ////b->B
        //c = a;
        ////c->A;
        ////a->A;
        ////b->B;



        //a = b;//   a.address = b.address
        ////b.camera.name = "666"; -> a.camer.name = "666";
        ////originalSize = m_object.transform.localScale;


        ////c->A;
        ////a->B;
        ////b->B;B is a address

    }

    public void GetSizeObj(GameObject currentobject)
    {
        m_object = currentobject;
    }

    public void ChangetoSmallSize()
    {

        if (currentSizeState != ManipulatedObjectSize.Small)
        {
            m_object.transform.localScale = originalScale * 0.5f;
            currentSizeState = ManipulatedObjectSize.Small;
        }

        Debug.Log("The object has been changed to Small alread");
    }

    public void ChangetoMediumSize()
    {

        if (currentSizeState != ManipulatedObjectSize.Medium)
        {
            m_object.transform.localScale = originalScale * 1.2f;
            currentSizeState = ManipulatedObjectSize.Medium;
        }

        Debug.Log("The object has been changed to Medium alread");
    }

    public void ChangetoLargeSize()
    {

        if (currentSizeState != ManipulatedObjectSize.Large)
        {
            m_object.transform.localScale = originalScale * 1.5f;
            currentSizeState = ManipulatedObjectSize.Large;
        }

        Debug.Log("The object has been changed to Large alread");
    }
}
