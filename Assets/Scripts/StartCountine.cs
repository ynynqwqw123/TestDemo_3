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
            print("当前Value的值为" + Value);
            Value--;
            yield return null;
            if (Value == 20)
                yield break;
        }
       // yield break;//跳出协程  相当于普通方法的return
        print("Hello World");

        yield return null;  //表示暂缓一帧，在下一帧接着往下处理，也有人习惯写成yield return 0 或yield return 1
        //yield return num;的写法其实后面的数字是不起作用的，不管为多少，表示都是在下一帧接着处理。
        yield return new WaitForSeconds(1);  //该参数受Time.Scale的影响
        yield return new WaitForEndOfFrame();//等待所有相机与GUI渲染之后，直到帧结束，继续执行后续代码
        /*----------------------------------TIPS----------------------------------------*/
        //在同一帧里执行的两个协程，不论先后关系如何，不论WaitForSeconds给定的值为多少，  |
        //yield return null所在的协程都要比yield return new WaitForSeconds的协程更先执行。|
        //同类型的协程则跟其开启的先后顺序相关：                                          |
        // yield return null 和yield return waitforseconds尽量不要一起用 可能会造成顺序混乱
        /*----------------------------------TIPS----------------------------------------  |*/
        yield return new WaitForFixedUpdate();       //等待下一個FixedUpdate()之后，继续执行代码
        yield return new WaitForSecondsRealtime(1); //等待指定的秒种后将继续向下执行，该参数不受Time.Scale的影响
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
