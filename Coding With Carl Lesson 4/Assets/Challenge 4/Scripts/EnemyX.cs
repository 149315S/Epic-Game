using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed = 80f;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private SpawnManagerX spawnManagerX;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player Goal");
        spawnManagerX = GameObject.Find("Spawn Manager").GetComponent<SpawnManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);
        speed = 100 + spawnManagerX.waveCount * 10;
        if(transform.position.x < -25)
        {
            Destroy(gameObject);
        }
        if(transform.position.x > 25)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < -15)
        {
            Destroy(gameObject);
        }
        if(transform.position.z > 35)
        {
            Destroy(gameObject);
        }
        if(transform.position.y < -6)
        {
            Destroy(gameObject);
        }
        if(transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }
    }
}
