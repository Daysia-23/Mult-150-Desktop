using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject npcPrefab;
    
    void Start()
    {
        Vector3 spawnPosition = new Vector3(0f, 1f, 0f);
        for (int i = 0; i < 10; i++)
        {
            Instantiate(npcPrefab, spawnPosition, Quaternion.identity);
            spawnPosition.x += 2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(npcPrefab);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(npcPrefab, transform.position, transform.rotation);
        }
    }
}
