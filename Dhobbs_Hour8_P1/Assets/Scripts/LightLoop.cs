using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LightLoop : MonoBehaviour
{
    Light lightComponent;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
        lightComponent.intensity  = 15f;
        float bulb = lightComponent.intensity;
        
    }

    // Update is called once per frame
    void Update()
    {
        bool t = nput();
        
        
        
        
    }

    void lightLoop()
    {
     
        
      
    }

    void stopLights(bool t)
    {

     
    }

    bool nput()
    {
        bool input = Input.GetKey(KeyCode.L);
        if (input)
        {
            lightComponent.intensity = 10f;
            UnityEngine.Debug.Log("Lights on");
            lightComponent.intensity = 0f;
            UnityEngine.Debug.Log("Light out");
        
        }
        else
        {
            lightComponent.intensity = 0f;
            UnityEngine.Debug.Log("Light is still off");
        

        }
        return input;
    }
}
