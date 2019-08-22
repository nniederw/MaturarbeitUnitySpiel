using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] public static float velocity = 10;
    [SerializeField] private float sidewaysForce = 50;
    [SerializeField] private float accelerationEnergyCost = 0.01f;

    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
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

        if (velocity + variables.shipAcceleration >= 0)
        {
            if (variables.LeftEnergy() >= variables.shipAcceleration)
            {
                variables.AddEnergy(accelerationEnergyCost * Mathf.Abs(variables.shipAcceleration) * -1);
                velocity += variables.shipAcceleration;
                variables.ScrollWheel -= variables.shipAcceleration * 0.2f;
            }
            else
            {
                variables.ScrollWheel -= variables.shipAcceleration * 0.2f;
            }
        }
        else
        {
            velocity = 0;
        }
        rb.velocity = velocity * transform.forward;
    }
}
