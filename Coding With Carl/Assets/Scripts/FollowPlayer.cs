using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private bool cameraSetting = false;
    //Refrences game object for database
    public GameObject player;  
    //sets local variable for offset
    private Vector3 offset = new Vector3(0,10,-10);    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
        cameraSetting = !cameraSetting;
        }
        if(cameraSetting = false)
        {
        transform.position = player.transform.position + offset;
        }
        else if(cameraSetting = false)
        {
        transform.position = player.transform.position;
        }
    }
}
