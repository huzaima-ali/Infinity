using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointsSpawner : MonoBehaviour
{
    public GameObject CheckPoints;
    public float StartDelay = 2;
    public float RepeatRate = 2;
    //private float SpawnRangeX = 200;
    //private float SpawnRangeZ = 1000;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnChecks", StartDelay, RepeatRate);
        for (int i = 0; i < 5; i++)
        {
            SpawnChecks();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private Vector3 GenerateRandomPos()
    //{
    //    float spawnPosX = Random.Range(-SpawnRangeX, SpawnRangeX);
    //    float spawnPosZ = Random.Range(-SpawnRangeZ, SpawnRangeZ);
    //    Vector3 RandomPos = new Vector3(spawnPosX, 10f, spawnPosZ);
    //    return RandomPos;
    //}

    //void CheckSpawn()
    //{
    //   Instantiate(CheckPoints, GenerateRandomPos(), CheckPoints.transform.rotation);
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.GetComponent<Collider>() != null)
    //        Destroy(gameObject);
    //}

    void SpawnChecks()
    {
        int checkSpawnIndex = Random.Range(3, 6);    //random point to spawn checkpoints
        Transform SpawnPoint = transform.GetChild(checkSpawnIndex).transform;
        Instantiate(CheckPoints, SpawnPoint.position, Quaternion.identity, transform);
    }

    
}
