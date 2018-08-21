using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPosition : MonoBehaviour
{

    float xx;
    float yy;
    float zz;
    //float rx;
    //float ry;
    //float rz;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //获取骨骼Transform组件下的position

        xx = GameObject.Find("Gun 1").GetComponent<Transform>().position.x;
        yy = GameObject.Find("Gun 1").GetComponent<Transform>().position.y -0.071f;//相对位置，下同
        zz = GameObject.Find("Gun 1").GetComponent<Transform>().position.z -0.020f;

        //设置目标Transform组件下的position
        GameObject.Find("Gun_2").GetComponent<Transform>().position = new Vector3(xx, yy, zz);

        //获取对象Transform 组件下的 rotation

        //rx = GameObject.Find("Gun 1").GetComponent<Transform>().localEulerAngles.x-78.69f;
        //ry = GameObject.Find("Gun 1").GetComponent<Transform>().localEulerAngles.y +180f;
        //rz = GameObject.Find("Gun 1").GetComponent<Transform>().localEulerAngles.z+90f;

        ////设置对象Transform组件下的 rotation
        //GameObject.Find("M4A1_Sopmod").GetComponent<Transform>().rotation = Quaternion.Euler(rx, ry, rz);
        //Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);




    }
  
}
