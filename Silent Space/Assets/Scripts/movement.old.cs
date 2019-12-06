using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] public static float forwardVelocity = 10;
    [SerializeField] private float sidewaysForce = 50;
    [SerializeField] private float accelerationEnergyCost = 0.01f;
    private Vector3 v3;
    [SerializeField] private Vector3 debug;
    [SerializeField] private Transform debugtrans;
    private  Vector3 oldVelocityForward;
    private  float angle;
    private  Vector3 V3forwardVelocity;
    private Vector3 angularVelocity;
    private Rigidbody rb;




    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        oldVelocityForward = Vector3.Scale(transform.forward, rb.velocity);
    }

    private void FixedUpdate()
    {
        debug = rb.velocity;
        V3forwardVelocity = Vector3.Scale(rb.velocity, transform.forward);
        forwardVelocity = V3forwardVelocity.magnitude;

        DirectionalMovment();

        rb.AddForce(variables.shipAcceleration * transform.forward);
        if (forwardVelocity + variables.shipAcceleration >= 0)
        {
            if (variables.LeftEnergy() >= variables.shipAcceleration)
            {
                variables.AddEnergy(accelerationEnergyCost * Mathf.Abs(variables.shipAcceleration) * -1);
                rb.AddForce(transform.forward *variables.shipAcceleration);
                variables.ScrollWheel -= variables.shipAcceleration * 0.2f;
            }
            else
            {
                variables.ScrollWheel -= variables.shipAcceleration * 0.2f;
            }
        }
        else
        {
            rb.velocity = 0 * transform.forward;
        }
    }
    void DirectionalMovment()
    {
        angularVelocity = new Vector3(0, 0, 0);

        if (keyManager.GoUp())
        {
            angularVelocity.x = -1f;
        }
        if (keyManager.GoDown())
        {
            angularVelocity.x = 1f;
        }
        if (keyManager.GoRight())
        {
            angularVelocity.y = 1f;
        }
        if (keyManager.GoLeft())
        {
            angularVelocity.y = -1f;
        }
        rb.angularVelocity = transform.rotation * angularVelocity;

        rb.velocity += -Vector3.Scale(transform.forward, rb.velocity)+ oldVelocityForward;

        //rb.velocity += ((transform.forward - oldVelocityForward) * V3forwardVelocity.magnitude);


        oldVelocityForward = Vector3.Scale(transform.forward, rb.velocity);
    }
}
