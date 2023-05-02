using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;
    private float Movement = 1.5f;
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        { 
            transform.Translate(new Vector3(Movement,0,0));
        }
        if(Input.GetKeyDown(KeyCode.A))
        { 
            transform.Translate(-Movement,0,0);
        }
        if(Input.GetKeyDown(KeyCode.W))
        { 
            transform.Translate(0,0,Movement);
        }
        if(Input.GetKeyDown(KeyCode.S))
        { 
            transform.Translate(0,0,-Movement);
        }  
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
