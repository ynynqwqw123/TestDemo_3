using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{
    public Transform m_Target;
    public float angleBetween = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir = m_Target.position - transform.position;
        angleBetween = Vector3.Angle(transform.forward, targetDir);

        if(Input.GetKey(KeyCode.UpArrow)) //¡ü¼ýÍ·
        {

        }
    }
}
