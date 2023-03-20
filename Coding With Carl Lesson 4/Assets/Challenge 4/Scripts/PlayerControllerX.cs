using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private Rigidbody playerRb;
    private float speed = 500;
    private GameObject focalPoint;

    public bool hasPowerup;
    public GameObject powerupIndicator;
    public int powerUpDuration = 5;

    private float normalStrength = 10; // how hard to hit enemy without powerup
    private float powerupStrength = 25; // how hard to hit enemy with powerup
    public float boostSpeed = 5; //
    Vector3 Zero = new Vector3(0,0,0);
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    void Update()
    {
        // Add force to player in direction of the focal point (and camera)
        float verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * verticalInput * speed * Time.deltaTime); 

        // Set powerup indicator position to beneath player
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.6f, 0);

        if (Input.GetKey(KeyCode.Space))
        {
            playerRb.AddForce(focalPoint.transform.forward * boostSpeed * speed * Time.deltaTime);
        }
        //Stops out-of-bounds no clipping
        if(transform.position.x < -25)
        {
            transform.position = Zero;
        }
        if(transform.position.x > 25)
        {
            transform.position = Zero;
        }
        if(transform.position.z < -15)
        {
            transform.position = Zero;
        }
        if(transform.position.z > 35)
        {
            transform.position = Zero;
        }
        if(transform.position.y < -6)
        {
            transform.position = Zero;
        }
        if(transform.position.y > 6)
        {
            transform.position = Zero;
        }
    }

    // If Player collides with powerup, activate powerup
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
            hasPowerup = true;
            powerupIndicator.SetActive(true);
            boostSpeed = 7.5f;
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    // Coroutine to count down powerup duration
   IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(5);
        hasPowerup = false; 
        boostSpeed = 5;
        powerupIndicator.gameObject.SetActive(false);
    }

    // If Player collides with enemy
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = other.gameObject.transform.position - transform.position; 
           
            if(hasPowerup) // if have powerup hit enemy with powerup force
            {
                enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
            }
            else // if no powerup, hit enemy with normal strength 
            {
                enemyRigidbody.AddForce(awayFromPlayer * normalStrength, ForceMode.Impulse);
            }
        }
    }
}
