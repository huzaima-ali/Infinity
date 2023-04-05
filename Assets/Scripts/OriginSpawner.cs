using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginSpawner : MonoBehaviour
{
    GroundSpawner originSpawn;
    // Start is called before the first frame update
    void Start()
    {
        originSpawn = GameObject.FindObjectOfType<GroundSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        originSpawn.GroundSpawning();
        Destroy(gameObject, 1.5f);
        Debug.Log("Destroyed");
    }

   

}
