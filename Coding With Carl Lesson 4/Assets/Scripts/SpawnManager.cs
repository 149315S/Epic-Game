using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, GenerateSpawnPosition, enemyPrefab.transform.rotation);
    }

    private Vector3 GenerateSpawnPosition ()
    {
        float SpawnPosX = Random.Range(-spawnRange, spawnRange);
        float SpawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(SpawnPosX, 0, SpawnPosZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
