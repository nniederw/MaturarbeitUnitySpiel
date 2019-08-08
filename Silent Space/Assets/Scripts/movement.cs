using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    private float tempFloat = 0;

    [SerializeField] public static float velocity = 10;
    [SerializeField] private float sidewaysForce = 50;
    [SerializeField] private float accelerationSensitivity = 0.01f;

    private double currentX;
    private double currentY;
    private double currentZ;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        currentX = transform.rotation.x;
        currentY = transform.rotation.y;
        currentZ = transform.rotation.z;

    }



    private void FixedUpdate()
    {


        rb.AddForce(variables.shipAcceleration * transform.forward);



        if (keyManager.GoUp())
        {
            rb.AddTorque(transform.right * -sidewaysForce * 60 * Time.deltaTime);
        }
        if (keyManager.GoLeft())
        {
            rb.AddTorque(transform.up * -sidewaysForce * 60 * Time.deltaTime);
        }
        if (keyManager.GoDown())
        {
            rb.AddTorque(transform.right * sidewaysForce * 60 * Time.deltaTime);
        }
        if (keyManager.GoRight())
        {
            rb.AddTorque(transform.up * sidewaysForce * 60 * Time.deltaTime);
        }


        tempFloat =  variables.shipAcceleration * accelerationSensitivity;
        if (tempFloat >= 0)
        {
            if (variables.LeftEnergy() >= tempFloat)
            {
                variables.AddEnergy(tempFloat);
                velocity += tempFloat;
                variables.ScrollWheel -= tempFloat;
            }
            else {
                variables.ScrollWheel -= tempFloat;

            }



        }
        else
        {
            velocity = 0;
        }

        rb.velocity = velocity * transform.forward;


    }



}
