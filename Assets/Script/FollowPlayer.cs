using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; //ターゲットへの参照

    // Update is called once per frame
    void Update()
    {
        //自分の座標にtargetの座標を代入する
        GetComponent<Transform>().position = target.position;
    }
}
