using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTimer : MonoBehaviour {

    public float timeMax = 5f;
    public float timer = 0f;
    GameObject m_obejct;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () 
    {
        if(timer > timeMax)
        {
            Debug.Log("Time has exceeded than 5s");
            timer = 0;
            ClearCurrentObject();
        }

        timer += Time.deltaTime;
		
	}

    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Sphere" || collision.gameObject.name == "Cube")
        {
            timer = 0;
        }
    }

    void ClearCurrentObject()
    {
        //DetectionManager.Get().GetCurrentGameObject();
        DetectionManager.Get().m_ManipulatedObject = null;
    }
}
