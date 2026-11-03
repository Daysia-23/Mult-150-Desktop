using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnTriggerEnter(Collider other)
    {
        int bounceCount = 0;
        if (bounceCount < 3)
        {
            bounceCount++;
        }
        Debug.Log("Bounce Count: " + bounceCount);
        
    }
    
    
    
}
