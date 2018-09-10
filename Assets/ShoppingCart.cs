using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingCart : MonoBehaviour {

    private Vector3 pointZero;
    private Vector3 pointCart;
    private Vector3 pointMove;
    public GameObject Cart;
    public Material red;

    public AudioClip clip;

    public float bigScale;

    void Start () {
        pointZero = transform.position;
    }

    public void Update () {
        pointMove = gameObject.transform.position;           //实时获取物体的位置
        pointCart = Cart.GetComponent<Transform>().position; //实时获取购物车的位置

        if (Vector3.Distance(transform.position, pointCart) < 1) //判断以上两个位置之间的距离
        {
            Cart.transform.localScale = new Vector3(bigScale, bigScale, bigScale); //购物车放大
            Cart.GetComponent<MeshRenderer>().materials[1] = red;
        }

        if (Vector3.Distance(transform.position, pointCart) < 0.1)
        {
            Cart.GetComponent<MeshRenderer>().materials[1].color = Color.red;
            Destroy(gameObject);                                     //销毁物体
            AudioSource.PlayClipAtPoint(clip, transform.position);   //音效
        }

        if (Vector3.Distance(transform.position, pointCart) > 1)
        {
            Cart.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F); //距离远，购物车缩小
            Cart.GetComponent<MeshRenderer>().materials[1] = red;
        }
    }
}
