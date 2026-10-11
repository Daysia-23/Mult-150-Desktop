using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birthday3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int day = 0;

        while (day < 31)
        {
            day++;
           Debug.Log("5-" + day); 
            if (day == 22)
            {
                day++;
                Debug.Log("It's my birthday");
            }

           
        }
        
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
