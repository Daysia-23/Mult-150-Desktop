using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Script : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject LTRigger;
    GameObject RTRigger;
    void Start()
    {
        LTRigger = GetComponent<GameObject>();
        RTRigger = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " has entered the cube");
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + " is still in the cube");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " has left the cube");
    }
}
