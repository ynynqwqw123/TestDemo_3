using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MathfScript : MonoBehaviour
{
    //Mathf  Class
    private float deg = 30.0f;//角度為30度
    private int number=20;
    void Start()
    {
/*----------------------------------TIPS----------------------------------------*/
/*------------------------------静态变量弧度和度的变换------------------------------*/
        float rad = deg * Mathf.Deg2Rad;
        Debug.Log("弧度值：" + rad);
        float value = rad * Mathf.Rad2Deg;
        Debug.Log("度为：" + value);
/*----------------------------------Clamp将值限定在范围内-----------------------------*/
        int outValue =0;
        outValue = Mathf.Clamp(number, 10, 100);//返回10  min 和max取值
        Debug.Log("输出为：" + outValue);
        outValue = Mathf.Clamp(number, 10, 100);//返回20
        Debug.Log("输出为：" + outValue);
        outValue = Mathf.Clamp(105, 10, 100);//返回105
        Debug.Log("输出为：" + outValue);
        float outFloat = 0.2f;
        Debug.Log("输出为:"+Mathf.Clamp01(outFloat));
        Mathf.Ceil(10.1f);//向上取整 返回11
        Mathf.Floor(10.1f);//返回10
        Mathf.DeltaAngle(1080f, 90f);//两个角度之间计算最短的距离
        //Mathf.Exp()
    }
    float a, b = 0;
    float maxAngle = 90.0f;
    float minAngle = 0;
    void Update()
    {
 /*----------------------------------非常常见Lerp以及LerpAngle----------------------------------------*/
        a = Mathf.Lerp(a,b,0.1f);//先快后慢
        print(a);
        float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time);
        transform.eulerAngles = new Vector3(0, angle, 0);
        MovePositon();
/*----------------------------------TIPS----------------------------------------*/
    }

    public void MovePositon()
    {   
        //插值
        float xPos = Mathf.Lerp(0, 100, Time.time/100);
        this.transform.position = new Vector3(xPos, 0, 0);
    }

    //Mathf MoveToWards--做匀速运动
    float speed = 3f;
    private void MoveTowards()
    {
        float x = this.transform.position.x;
        float newX = Mathf.MoveTowards(x, 10, Time.deltaTime*speed);
        newX = Mathf.MoveTowards(x, -10, 0.02f);
    }

    private void PingPongMove()
    {   
        //0 -10进行pingpiong运动  （来回运动） 0 0.1 0.2 ... 10 9.9 9.8 ... 0 0.1... 10
        this.transform.position = new Vector3(Mathf.PingPong(Time.time*speed, 10), 0, 0);

        // 5 -10 运动   0 +x = num +x
        this.transform.position = new Vector3(5 + Mathf.PingPong(Time.time * speed,5), 0, 0)
;    }
}
