﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //speedを制御する
    public float speed = 10;

    void FixedUpdate()
    {
        //入力をxとzに代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //同一のGameObjectが持つRigidbodyコンポーネントを取得
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        //rigidbodyのx軸(横)とz軸(奥)に力を加える
        //speedをかける
        rigidbody.AddForce(x*speed, 0, z*speed);
    }
}
