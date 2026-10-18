using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");

        if (horizontalValue != 0)
        {
            Debug.Log("Horizontal movement selected: " + horizontalValue);
        }
        if (verticalValue != 0)
        {
            Debug.Log("Vertical movement selected: " + verticalValue);
        }

        bool isKeyDown = Input.GetKey(KeyCode.A);
        if (isKeyDown)
        {
            Debug.Log("The 'A' key is pressed down:");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("The 'Z' key is pressed down:");
        }
    }
}
