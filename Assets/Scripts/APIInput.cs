using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIInput : MonoBehaviour
{
    //使用该类来读取传统游戏输入中设置的轴，以及访问移动设备上的多点触控/加速度计数据
    private float xAxis;
    private float yAxis;
    void Start()
    {
        //要读取轴用
       
    }

    // Update is called once per frame
    void Update()
    {
        //对应键盘的A和D键 或者箭头键
        xAxis = Input.GetAxis("Horizontal"); //值为-1 到1
        yAxis = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
    }
}
