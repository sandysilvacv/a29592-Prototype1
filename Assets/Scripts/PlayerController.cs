using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private variables 
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Mover o ve�culo para frente

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput );
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        // we turn the vihacle
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }


    }

