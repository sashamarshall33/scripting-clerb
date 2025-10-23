using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //variables
    // Make Player move forward - apply physics and manipulate the ridgid body

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //equivilent of console.log
        Debug.Log("boop");
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Executes logic at fixed intervals : default .02 seconds (50 times per second)
    private void FixedUpdate()
    {
        
        // move player if key is pressed
        if (Input.GetKey(KeyCode.W))
        {
            // manipulating the forces acted upon the dealcared rigid body
            rb.AddForce(transform.forward, ForceMode.Impulse);
        }
    } 
}
