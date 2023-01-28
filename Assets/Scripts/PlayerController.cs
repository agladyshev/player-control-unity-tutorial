using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //forward moves object 1 metre
        //deltaTime is second / number of frames per second 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        if (forwardInput != 0)
        {
            // If the vehicle is moving, allow steering 
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        } 
    }
}
