using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectCreate : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {   
        //���ֿ�¡����ķ���
        GameObject go = new GameObject("Cube");// ���Ը���prefab��������һ��������п�¡
        GameObject.CreatePrimitive(PrimitiveType.Plane);
        GameObject.Instantiate(prefab);
    }

    //�����������ص����
    public void AddComponentForGo()
    {
        prefab.AddComponent<Rigidbody>();
        prefab.AddComponent<TImeClass>();
    }

    //��ֹ��������������
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
        //FindObjectOfType //��ȫ���н��������ҵ��������͵����  ���ص�һ���ҵ���
        //FindObjectsOfType ��ȫ���н��������ҵ��������͵��������
        Light light = FindObjectOfType<Light>();
        light.enabled = false;
        Transform[] ts = FindObjectsOfType<Transform>();// ������ δ�������Ϸ����
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
