using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOjbectSendMessage : MonoBehaviour
{
    // ��Ϣ�ķ��ͺͽ���
    //BroadcastMessage Ч������ô���Ϸ������κ������ÿ��MonoBehavior����ΪmethodName�ķ���
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
