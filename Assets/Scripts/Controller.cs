using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    CharacterController m_CharacterController;
    public float Speed { get; private set; } = 2.0f;
    public int runCount = 10000;
    void Start()
    {
        m_CharacterController = transform.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxisRaw("Vertical"));// 水平  垂直  //x y z
        if (move.sqrMagnitude > 1.0f)
            move.Normalize();
        move = move * Speed * Time.deltaTime;
        m_CharacterController.Move(move);
        //transform.forward  用来自动对物体旋转值算出前进方向的变量  --旋转会对transform.forward值产生影响
        //transform.forward  返回表示世界坐标系变换的蓝轴（z轴）的归一化向量 //
        //TimeScale 可以用作游戏的慢放等  快放等

        float time1 = Time.realtimeSinceStartup;
        for (int i = 0; i < runCount;i++)
        {
            Method1();
        }
        float time2 = Time.realtimeSinceStartup;
        Debug.Log(time2 - time1);
        float time3 = Time.realtimeSinceStartup;
        for (int i = 0; i < runCount; i++)
        {
            Method1();
        }
        float time4 = Time.realtimeSinceStartup;
        Debug.Log(time4 - time3);
    }

    //测试 某个解决方案是否占用性能
    void Method1()
    {
        int i = 1 + 2;
    }
    void Method2()
    {
        int j = 1 * 2;
    }
}
