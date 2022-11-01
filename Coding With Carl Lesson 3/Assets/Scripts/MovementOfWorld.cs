using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOfWorld : MonoBehaviour
{
    private float speed = 15;
    private float leftborder = -15;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < leftborder && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
