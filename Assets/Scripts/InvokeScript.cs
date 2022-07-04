using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    // CanelInvoke 取消该monobehaviour 上所有的Invoke调用
    //InvokeRepeating 在time后調用methodName方法，然后没repeatRate秒调用一次
    //IsInvoking 是否有任何待处理的methofName调用
    void Start()
    {
        Invoke("Fun1", 2);
        Invoke("Fun2", 3);
        Invoke("Fun3", 4);
        InvokeRepeating("Fun1", 4.5f, 2);
    }
    public void Fun1()
    {
        Debug.Log("Fun1");
    }
    public void Fun2()
    {
        Debug.Log("Fun2");
    }
    public void Fun3()
    {
        Debug.Log("Fun3");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke();
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            Debug.Log(IsInvoking());
        }
    }
}
