using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UGUIEventListener : UnityEngine.EventSystems.EventTrigger
{
    public UnityAction<GameObject> onClick;  //UnityAction 是Unity自己的事件传递系统 类似C#委托和事件一样  属于函数指针
    public delegate void fff();
    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        if(onClick != null)
        {
            onClick(gameObject); //调用unityaction 参数委托
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
