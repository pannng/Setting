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

    private AudioSource bubble;

    public float bigScale;

    void Start () {
        pointZero = transform.position;
        bubble = this.GetComponent<AudioSource>();
    }

    public void Update () {
        pointMove = gameObject.transform.position;
        pointCart = Cart.GetComponent<Transform>().position;

        if (Vector3.Distance(transform.position, pointCart) < 1)
        {
            Cart.transform.localScale = new Vector3(bigScale, bigScale, bigScale);
            Cart.GetComponent<MeshRenderer>().materials[1] = red;
        }

        if (Vector3.Distance(transform.position , pointCart) < 0.1)
        {
            Cart.GetComponent<MeshRenderer>().materials[1] = red;
            Destroy(gameObject);
            bubble.Play();    
        }

        if (Vector3.Distance(transform.position, pointCart) > 1)
        {
            Cart.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);
            Cart.GetComponent<MeshRenderer>().materials[1] = red;
        }
    }
}
