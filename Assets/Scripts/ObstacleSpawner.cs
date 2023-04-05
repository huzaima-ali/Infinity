using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] ObstaclePrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int ObstacleIndex = Random.Range(0, ObstaclePrefabs.Length);
        Vector3 RandomSpawnPos = new Vector3(Random.Range(-1240, 1240), 0.511f, Random.Range(-200, 240));
        Instantiate(ObstaclePrefabs[ObstacleIndex], RandomSpawnPos, ObstaclePrefabs[ObstacleIndex].transform.rotation);
    }

   
}
