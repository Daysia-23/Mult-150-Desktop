using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PLayerInput2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            UnityEngine.Debug.Log("The A key is pressed down");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            UnityEngine.Debug.Log("The Z key is pressed down");
        }

        bool isButtonDown;
        isButtonDown = Input.GetMouseButtonDown(0);
        isButtonDown = Input.GetMouseButtonDown(1);
        isButtonDown = Input.GetMouseButtonDown(3);

       
        
    }
    
}
