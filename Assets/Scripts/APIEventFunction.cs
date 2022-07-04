using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIEventFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }
    private void Awake()
    {
        Debug.Log("Awake");
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
    private void Reset()
    {
        Debug.Log("执行Reset方法");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    private void OnDisable()
    {
        Debug.Log("Disable");
    }
    private void OnApplicationPause()
    {
        Debug.Log("OnApplicationPause");
    }
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }
    private void FixedUpdate()
    {
        Debug.Log("fixedUpdate"); //  固定次数
        //yield waitForFixedUpdate
    }
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    private void OnDestroy()
    {
        Debug.Log("Destroy");
    }

    //Awake --> OnEnable -->OnApplicationPause -->Start -->FixedUpdate -->Update -->LateUpdate -->OnApplicationQuit -->Disable -->Destroy
}
