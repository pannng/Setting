using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getcomponent : MonoBehaviour {

    public Transform[] GetTransforms;

    void start ()
    {
        GetTransforms = GetComponentsInChildren<Transform>(true);

        foreach (Transform child in GetTransforms)
        {
            print(child.name);
        }
    }
    void update ()
    {

    }
        

}
