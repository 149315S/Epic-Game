using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Privarte Variables
    private float speed = 15.0f;
    private float turnSpeed = 35f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //Player movement
    horizontalInput = Input.GetAxis("Horizontal");
    forwardInput = Input.GetAxis("Vertical");
    //Player's speed
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
