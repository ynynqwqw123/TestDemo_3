using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class AddListenerFunction : MonoBehaviour
{
    //给当前所有UI 增加监听方法
    public Image Image1;
    public Button button1;
    public Button button2;
    public Text text1;
    private UnityAction<GameObject> action1 ;
    private UnityAction action;
    private void Awake()
    {
        
        button1.onClick.AddListener(delegate () 
        { 
            

        });
        action1 = delegate (GameObject gameObject)
        {

        };
        action1 += Test;
        action = Test1;
    }
    void Start()
    {
        button1.onClick.AddListener(delegate() {
            OnClick(gameObject);
            });
        UGUIEventListener.Get(Image1.gameObject).onClick = OnClick;
    }
    private void Test(GameObject go)
    {
        go = gameObject;
    }
    private void Test1()
    {

    }

    void OnClick(GameObject go)
    {
       if(go.gameObject == button1.gameObject)
       {
            Debug.Log("点击按钮1");
       }
       else if(go.gameObject == Image1.gameObject)
       {
            Debug.Log("点击图片");
       }
       else if(go.gameObject == text1.gameObject)
       {
            Debug.Log("点击文本");
       }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
