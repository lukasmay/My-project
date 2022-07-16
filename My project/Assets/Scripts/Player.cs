using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidBodyComponent;
    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = True;
        }
    }

    private void FixedUpdate()
    {
        rigidBodyComponent.Velocity = new Vector3(horizontalInput, rigidBodyComponent.Velocity.y, 0);
        //if (Physics.OverlapSphere)

        if (jumpKeyWasPressed)
        {
            rigidBodyComponent.AddForce(Vector3.up, ForceMode.VelocityChange);
        }
    }
}
