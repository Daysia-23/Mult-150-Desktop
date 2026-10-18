using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light lightComponent;
    // Start is called before the first frame update
    
    void Start()
    {
        lightComponent = GetComponent<Light>  ();
        lightComponent.intensity = 100f;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            lightComponent.intensity = 10f;
        }
        else
        {
            lightComponent.intensity = 0f;
        }
    }
}
