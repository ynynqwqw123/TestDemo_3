using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCountine : MonoBehaviour
{
    public GameObject cube;
    public int Value = 50;
    void Start()
    {
        Debug.Log("hahaha1");
        Debug.Log("hahaha2");
        StartCoroutine(YieldReturnFunction());
        print("ssa");
    }

    private IEnumerator ie;
    /*----------Tips-----------*/
    // 
    //
    //
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ie = Fade();
            StartCoroutine(ie);
            //StartCoroutine("Fade");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            StopCoroutine(ie);
            //StopCoroutine("Fade");
        }
    }

    IEnumerator YieldReturnFunction()
    {
        print("yield return");
        while(Value>0)
        {
            print("��ǰValue��ֵΪ" + Value);
            Value--;
            yield return null;
            if (Value == 20)
                yield break;
        }
       // yield break;//����Э��  �൱����ͨ������return
        print("Hello World");

        yield return null;  //��ʾ�ݻ�һ֡������һ֡�������´���Ҳ����ϰ��д��yield return 0 ��yield return 1
        //yield return num;��д����ʵ����������ǲ������õģ�����Ϊ���٣���ʾ��������һ֡���Ŵ���
        yield return new WaitForSeconds(1);  //�ò�����Time.Scale��Ӱ��
        yield return new WaitForEndOfFrame();//�ȴ����������GUI��Ⱦ֮��ֱ��֡����������ִ�к�������
        /*----------------------------------TIPS----------------------------------------*/
        //��ͬһ֡��ִ�е�����Э�̣������Ⱥ��ϵ��Σ�����WaitForSeconds������ֵΪ���٣�  |
        //yield return null���ڵ�Э�̶�Ҫ��yield return new WaitForSeconds��Э�̸���ִ�С�|
        //ͬ���͵�Э������俪�����Ⱥ�˳����أ�                                          |
        // yield return null ��yield return waitforseconds������Ҫһ���� ���ܻ����˳�����
        /*----------------------------------TIPS----------------------------------------  |*/
        yield return new WaitForFixedUpdate();       //�ȴ���һ��FixedUpdate()֮�󣬼���ִ�д���
        yield return new WaitForSecondsRealtime(1); //�ȴ�ָ�������ֺ󽫼�������ִ�У��ò�������Time.Scale��Ӱ��
    }

    IEnumerator Fade()
    {
        for (; ; )
        {
            Color color = cube.GetComponent<MeshRenderer>().material.color;
            Color newcolor = Color.Lerp(color, Color.red, 0.02f);//
            cube.GetComponent<MeshRenderer>().material.color = newcolor;
            yield return new WaitForSeconds(0.02f);
            if(Mathf.Abs(Color.red.g - newcolor.g)<=0.01f)
            {
                break;
            }
        }
    }

    IEnumerator ColorAdd()
    {
        print("hahaColor");
        for(int i = 0;i<10000;i++ )
        {
            string t = i.ToString();
        }
        for (int i = 0; i < 100000; i++)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        cube.GetComponent<MeshRenderer>().material.color = Color.blue;
        print("hahaColor1");
        yield return null;
    }
}
