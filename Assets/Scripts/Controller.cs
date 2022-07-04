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
        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxisRaw("Vertical"));// ˮƽ  ��ֱ  //x y z
        if (move.sqrMagnitude > 1.0f)
            move.Normalize();
        move = move * Speed * Time.deltaTime;
        m_CharacterController.Move(move);
        //transform.forward  �����Զ���������תֵ���ǰ������ı���  --��ת���transform.forwardֵ����Ӱ��
        //transform.forward  ���ر�ʾ��������ϵ�任�����ᣨz�ᣩ�Ĺ�һ������ //
        //TimeScale ����������Ϸ�����ŵ�  ��ŵ�

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

    //���� ĳ����������Ƿ�ռ������
    void Method1()
    {
        int i = 1 + 2;
    }
    void Method2()
    {
        int j = 1 * 2;
    }
}
