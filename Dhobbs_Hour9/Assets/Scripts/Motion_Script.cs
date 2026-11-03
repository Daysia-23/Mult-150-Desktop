using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, 0, .01f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0, -.01f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-.01f, 0, 0);
        }
        
    }
}
