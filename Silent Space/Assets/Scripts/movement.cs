using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float forwardForce = 5;
    public float sidewaysForce = 50;
    private float currentX;
    private float currentY;
    private float currentZ;
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
        


        if (keyManager.GoUp())
        {
            rb.AddTorque(transform.right * -sidewaysForce);
        }
        if (keyManager.GoLeft())
        {
            rb.AddTorque(transform.up * -sidewaysForce);
        }
        if (keyManager.GoDown())
        {
            rb.AddTorque(transform.right * sidewaysForce);
        }
        if (keyManager.GoRight())
        {
            rb.AddTorque(transform.up * sidewaysForce);
        }


        rb.AddForce(transform.forward * forwardForce);
        

    }

}
