using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnPosY = 30;
    private float spawnRandomTime = 3;
    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnRandomTime);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-22,8), spawnPosY, 3);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[Random.Range(0, 2)], spawnPos, ballPrefabs[Random.Range(0, 2)].transform.rotation);
    }

}
