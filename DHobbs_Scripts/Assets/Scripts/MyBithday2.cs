using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBithday2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int day = 1; day < 31; day++)
        {
           Debug.Log("5-" + day); 


           if (day == 23)
            {
                
                Debug.Log("It's my birthday");
            }
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
