using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get player Input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Vechicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);
        // transform.Translate(0,0,1);

        // Vechicle turn y Axis 
        transform.Rotate(Vector3.up ,Time.deltaTime*turnSpeed*horizontalInput);
    }
}
