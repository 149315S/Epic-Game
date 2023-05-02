using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathWr1 : MonoBehaviour
{
    private Rigidbody enemyRb;
    public GameObject NodeOne;
    public Vector3 = new Vector3 = GameObject.Find("MovementNode1").transform.position;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}   