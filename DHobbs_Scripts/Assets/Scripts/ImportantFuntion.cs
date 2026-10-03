using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantFuntion : MonoBehaviour
{
    public int runSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start runs before a project updates");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This is called oncce per frame");
    }
}
