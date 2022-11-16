using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10;
    public float jumps = 1;
    public float maxJumps = 1;
    // Start is called before the first frame update
    void Start()
    {
        public float speed = 10.0f;
        public float rotationSpeed = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jumps > 0)
        { 
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumps --;
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            jumps = maxJumps;
        }
    }
}