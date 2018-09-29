using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryingOn : MonoBehaviour {

    private Vector3 pointZero;
    private Vector3 pointBody;
    private Vector3 pointMove;
    public GameObject Body;

    public AudioClip clip;

    void Start()
    {
        pointZero = transform.position;
    }

    public void Update()
    {
        pointMove = gameObject.transform.position;           //实时获取物体的位置
        pointBody = Body.GetComponent<Transform>().position; //实时获取购物车的位置

        if (Vector3.Distance(transform.position, pointBody) < 0.2)
        {
            Destroy(gameObject);                                     //销毁物体
            AudioSource.PlayClipAtPoint(clip, transform.position);   //音效
        }
    }
}
