using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIInput : MonoBehaviour
{
    //ʹ�ø�������ȡ��ͳ��Ϸ���������õ��ᣬ�Լ������ƶ��豸�ϵĶ�㴥��/���ٶȼ�����
    private float xAxis;
    private float yAxis;
    void Start()
    {
        //Ҫ��ȡ����
       
    }

    // Update is called once per frame
    void Update()
    {
        //��Ӧ���̵�A��D�� ���߼�ͷ��
        xAxis = Input.GetAxis("Horizontal"); //ֵΪ-1 ��1
        yAxis = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
    }
}
