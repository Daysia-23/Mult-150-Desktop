using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXvalue = Input.GetAxis("Mouse X");
        float mouseYvalue = Input.GetAxis("Mouse Y");
        
        if (mouseXvalue !=0)
        {
            UnityEngine.Debug.Log("Mouse X movement: " + mouseXvalue);
        }
        if (mouseYvalue !=0)
        {
            UnityEngine.Debug.Log("Mouse Y movement: " + mouseYvalue);
        }
    }
}
