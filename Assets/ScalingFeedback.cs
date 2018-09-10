using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingFeedback : MonoBehaviour {

    public float presentScaleX;

    public float CoolDownTime = 0.2F;
    float CoolDownLeft = 0.0F;

    public AudioClip clip;  //创建一个音效

    void Start()
    {
        presentScaleX = transform.localScale.x; //开始的时候获取原始尺寸
    }

    void Update () {
        presentScaleX = transform.localScale.x; //每时每刻都获取物体的尺寸

        if (CoolDownLeft > 0.0f)
        {
            CoolDownLeft -= Time.deltaTime;
            if (CoolDownLeft < 0.0F)
            {
                CoolDownLeft = 0.0F;
            }

        }

        if (presentScaleX > 1.99 && presentScaleX < 2.01 && CoolDownLeft <= 0.0F) //尺寸接近2倍的时候，播放音效
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
