using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TImeClass : MonoBehaviour
{
    // Time.deltaTime
    //Time.fixedDeltaTime   -- Time.fixedTime (This is the time in seconds since the start of the game.)
    //realtimeSinceStartup
    //frameCount 从游戏到运行的帧数
    //timeScale  让游戏暂停 或加速
    void Start()
    {
        //Time.deltaTime  //当前帧所占用的时间  最后一帧到当前帧的间隔
        Debug.Log("sss");
        Debug.Log(Time.deltaTime);   //控制了每一帧差不多的速度
        //Time.fixedDeltaTime 时间增量
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
       // Debug.Log("Fix + "+Time.deltaTime);       //每一帧都是固定  放在这里
    }
    //-----------------------总结------------------------------------//
    /*
        frameCount 是运行时所有的帧数 在Update里  1 2 3 4增加
        Time.time 和Time.fixedTime  游戏运行的时间 两者是差不多的     //两者时间差不多
        Time.timeSinceLevelLoad 场景加载结束开始即时  (Time.time Time.fixedTime  Time.timeSinceLevelLoad 差不多


        Time.realtimeSinceStartup 不受游戏暂停影响                                                                              
        Time.smoothDeltaTime 平滑的deltaTime 不会让deltaTime变化的过大
     */

}
