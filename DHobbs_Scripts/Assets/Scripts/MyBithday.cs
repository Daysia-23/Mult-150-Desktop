using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBithday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int month = 5;
        int day = 1;
         while (day <= 31)
        {
            Debug.Log(month + "-" + day);
        }
        
        if (day == 23)
        {
           
        }
        
        
        
        
        

        //for (month = 0; month <= 12; month++)
        //{
           
        //}
        //for (day = 1; day <= 31; day++)
        //{
            //Debug.Log(month + "/" + day);
        //}
        //if (month == 5 && day == 23)
        //{
          //Debug.Log("Its my bithday");  
        //}  
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
