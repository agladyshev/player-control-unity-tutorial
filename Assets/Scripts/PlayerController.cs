using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //forward moves object 1 metre
        //deltaTime is second / number of frames per second 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
