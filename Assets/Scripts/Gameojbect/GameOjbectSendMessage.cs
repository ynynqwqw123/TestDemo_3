using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOjbectSendMessage : MonoBehaviour
{
    // 消息的发送和接收
    //BroadcastMessage 效果為调用此游戏对象或任何子项的每个MonoBehavior上名为methodName的方法
    #region
    public  void Print(float damage)
    {
        print(damage);
    }
    public  void SendMessage()
    {
        //gameObject.BroadcastMessage("Print", 5.0f);
        gameObject.BroadcastMessage("Attack", null, SendMessageOptions.DontRequireReceiver);
        gameObject.SendMessage("Print", 5.0f);
    }
    #endregion
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SendMessage();
    }
}
