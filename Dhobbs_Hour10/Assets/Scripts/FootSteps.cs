using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical"))
        {
            audioSource.Play();
        }
        else if (Input.GetButtonUp("Horizontal") || Input.GetButtonUp("Vertical"))
        {
            audioSource.Stop();
        }
       
        

    }
    
}

