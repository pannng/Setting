using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingCart : MonoBehaviour {

    private Vector3 pointZero;
    private Vector3 pointCart;
    private Vector3 pointMove;
    public GameObject Cart;

    public Text ta;
    public Text tb;

    void Start () {
        pointZero = transform.position;
    }

    void Update () {
        pointMove = gameObject.transform.position;
        pointCart = Cart.GetComponent<Transform>().position;

        ta.text = pointCart.ToString();
        tb.text = transform.position.ToString();

        if (Vector3.Distance(transform.position , pointCart) < 0.1)
        {
            Destroy(gameObject);
        }
    }
}
