using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MathfScript : MonoBehaviour
{
    //Mathf  Class
    private float deg = 30.0f;//�ǶȞ�30��
    private int number=20;
    void Start()
    {
/*----------------------------------TIPS----------------------------------------*/
/*------------------------------��̬�������ȺͶȵı任------------------------------*/
        float rad = deg * Mathf.Deg2Rad;
        Debug.Log("����ֵ��" + rad);
        float value = rad * Mathf.Rad2Deg;
        Debug.Log("��Ϊ��" + value);
/*----------------------------------Clamp��ֵ�޶��ڷ�Χ��-----------------------------*/
        int outValue =0;
        outValue = Mathf.Clamp(number, 10, 100);//����10  min ��maxȡֵ
        Debug.Log("���Ϊ��" + outValue);
        outValue = Mathf.Clamp(number, 10, 100);//����20
        Debug.Log("���Ϊ��" + outValue);
        outValue = Mathf.Clamp(105, 10, 100);//����105
        Debug.Log("���Ϊ��" + outValue);
        float outFloat = 0.2f;
        Debug.Log("���Ϊ:"+Mathf.Clamp01(outFloat));
        Mathf.Ceil(10.1f);//����ȡ�� ����11
        Mathf.Floor(10.1f);//����10
        Mathf.DeltaAngle(1080f, 90f);//�����Ƕ�֮�������̵ľ���
        //Mathf.Exp()
    }
    float a, b = 0;
    float maxAngle = 90.0f;
    float minAngle = 0;
    void Update()
    {
 /*----------------------------------�ǳ�����Lerp�Լ�LerpAngle----------------------------------------*/
        a = Mathf.Lerp(a,b,0.1f);//�ȿ����
        print(a);
        float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time);
        transform.eulerAngles = new Vector3(0, angle, 0);
        MovePositon();
/*----------------------------------TIPS----------------------------------------*/
    }

    public void MovePositon()
    {   
        //��ֵ
        float xPos = Mathf.Lerp(0, 100, Time.time/100);
        this.transform.position = new Vector3(xPos, 0, 0);
    }

    //Mathf MoveToWards--�������˶�
    float speed = 3f;
    private void MoveTowards()
    {
        float x = this.transform.position.x;
        float newX = Mathf.MoveTowards(x, 10, Time.deltaTime*speed);
        newX = Mathf.MoveTowards(x, -10, 0.02f);
    }

    private void PingPongMove()
    {   
        //0 -10����pingpiong�˶�  �������˶��� 0 0.1 0.2 ... 10 9.9 9.8 ... 0 0.1... 10
        this.transform.position = new Vector3(Mathf.PingPong(Time.time*speed, 10), 0, 0);

        // 5 -10 �˶�   0 +x = num +x
        this.transform.position = new Vector3(5 + Mathf.PingPong(Time.time * speed,5), 0, 0)
;    }
}
