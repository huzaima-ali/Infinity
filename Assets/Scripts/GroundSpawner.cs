using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject[] GroundPrefab;
    Vector3 SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<3; i++)
        {
            GroundSpawning();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GroundSpawning()
    {
        int GroundIndex = Random.Range(0, GroundPrefab.Length);
        GameObject spawner = Instantiate(GroundPrefab[GroundIndex], SpawnPoint, GroundPrefab[GroundIndex].transform.rotation);
        SpawnPoint = spawner.transform.GetChild(2).transform.position;
    }


    /* private void OnTriggerEnter(Collider other)
     {
         int GroundIndex = Random.Range(0, GroundPrefab.Length);
         Instantiate(GroundPrefab[GroundIndex], new Vector3(0, 0, SpawnPoint), GroundPrefab[GroundIndex].transform.rotation);
         SpawnPoint += 90;
     }*/

}
