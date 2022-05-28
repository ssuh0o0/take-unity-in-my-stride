using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    [SerializeField] private float horsePower = 0;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometer;
    void Start() {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // Get player Input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Vechicle forward
        // transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);
        playerRb.AddRelativeForce(Vector3.forward* verticalInput*horsePower);
        // transform.Translate(0,0,1);

        // Vechicle turn y Axis 
        transform.Rotate(Vector3.up ,Time.deltaTime*turnSpeed*horizontalInput);

        speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 2.237f); // For kph, change 2.237 -> 3.6
        speedometer.SetText("Speed: "+speed+" m/h");
    }
}
