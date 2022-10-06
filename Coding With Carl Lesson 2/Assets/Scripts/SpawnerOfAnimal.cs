using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerOfAnimal : MonoBehaviour
{
    public GameObject[] animalPrefabs; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        if(Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPrefabs[animalIndex], new Vector3(0,0,20), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}