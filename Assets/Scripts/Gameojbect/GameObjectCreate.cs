using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectCreate : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {   
        //三种克隆物体的方法
        GameObject go = new GameObject("Cube");// 可以根据prefab或者另外一个物体进行克隆
        GameObject.CreatePrimitive(PrimitiveType.Plane);
        GameObject.Instantiate(prefab);
    }

    //给物体添加相关的组件
    public void AddComponentForGo()
    {
        prefab.AddComponent<Rigidbody>();
        prefab.AddComponent<TImeClass>();
    }

    //禁止或者启用相关组件
    public void EnableComponent()
    {
        prefab.transform.gameObject.SetActive(false);
        bool flag = transform.gameObject.activeInHierarchy;
        Debug.Log(prefab.activeInHierarchy);       
    }

    public void EngineObject()
    {
        //Destroy(this);
        DestroyImmediate(gameObject);
        DontDestroyOnLoad(this);
        //FindObjectOfType //从全局中进行搜索找到符合类型的组件  返回第一个找到的
        //FindObjectsOfType 从全局中进行搜索找到符合类型的所有组件
        Light light = FindObjectOfType<Light>();
        light.enabled = false;
        Transform[] ts = FindObjectsOfType<Transform>();// 不查找 未激活的游戏物体
        foreach(Transform t in ts)
        {
            Debug.Log(t);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
