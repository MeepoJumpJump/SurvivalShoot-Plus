using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_3Position : MonoBehaviour
{

    float xx_3;
    float yy_3;
    float zz_3;
    //float rx;
    //float ry;
    float rz_3;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //获取骨骼Transform组件下的position

        xx_3 = GameObject.Find("Gun 1").GetComponent<Transform>().position.x +0.1f ;
        yy_3 = GameObject.Find("Gun 1").GetComponent<Transform>().position.y ;//相对位置，下同
        zz_3 = GameObject.Find("Gun 1").GetComponent<Transform>().position.z +0.256f;

        //设置目标Transform组件下的position
        GameObject.Find("Gun_3").GetComponent<Transform>().position = new Vector3(xx_3, yy_3, zz_3);


        rz_3 = GameObject.Find("Gun 1").GetComponent<Transform>().localRotation.z + 0.256f;



    }

}
