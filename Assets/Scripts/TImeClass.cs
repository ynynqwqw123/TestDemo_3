using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TImeClass : MonoBehaviour
{
    // Time.deltaTime
    //Time.fixedDeltaTime   -- Time.fixedTime (This is the time in seconds since the start of the game.)
    //realtimeSinceStartup
    //frameCount ����Ϸ�����е�֡��
    //timeScale  ����Ϸ��ͣ �����
    void Start()
    {
        //Time.deltaTime  //��ǰ֡��ռ�õ�ʱ��  ���һ֡����ǰ֡�ļ��
        Debug.Log("sss");
        Debug.Log(Time.deltaTime);   //������ÿһ֡�����ٶ�
        //Time.fixedDeltaTime ʱ������
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Update is called once per frame
    void Update()
    {
        return;
        Debug.Log("Time.deltaTime:"+Time.deltaTime);
        Debug.Log("Time.fixedDeltaTime:" + Time.fixedDeltaTime);
        Debug.Log("Time.fixedTime:" + Time.fixedTime);
        Debug.Log("Time.frameCount:" + Time.frameCount);
        Debug.Log("Time.realtimeSinceStartup:" + Time.realtimeSinceStartup);
        Debug.Log("Time.smoothDeltaTime:" + Time.smoothDeltaTime);
        Debug.Log("Time.time:" + Time.time);
        Debug.Log("Time.timeScale:" + Time.timeScale);
        Debug.Log("Time.timeSinceLevelLoad:" + Time.timeSinceLevelLoad);
        Debug.Log("Time.unscaledTime:" + Time.unscaledTime);
    }
    private void FixedUpdate()
    {
       // Debug.Log("Fix + "+Time.deltaTime);       //ÿһ֡���ǹ̶�  ��������
    }
    //-----------------------�ܽ�------------------------------------//
    /*
        frameCount ������ʱ���е�֡�� ��Update��  1 2 3 4����
        Time.time ��Time.fixedTime  ��Ϸ���е�ʱ�� �����ǲ���     //����ʱ����
        Time.timeSinceLevelLoad �������ؽ�����ʼ��ʱ  (Time.time Time.fixedTime  Time.timeSinceLevelLoad ���


        Time.realtimeSinceStartup ������Ϸ��ͣӰ��                                                                              
        Time.smoothDeltaTime ƽ����deltaTime ������deltaTime�仯�Ĺ���
     */

}
