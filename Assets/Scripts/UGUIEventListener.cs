using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UGUIEventListener : UnityEngine.EventSystems.EventTrigger
{
    public UnityAction<GameObject> onClick;  //UnityAction ��Unity�Լ����¼�����ϵͳ ����C#ί�к��¼�һ��  ���ں���ָ��
    public delegate void fff();
    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        if(onClick != null)
        {
            onClick(gameObject); //����unityaction ����ί��
        }
    }

    static public UGUIEventListener Get(GameObject go)
    {
        UGUIEventListener listener = go.GetComponent<UGUIEventListener>();
        if(listener == null)
        {
            listener = go.AddComponent<UGUIEventListener>();
        }
        return listener;
    }

}
