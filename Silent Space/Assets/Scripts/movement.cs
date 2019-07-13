using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float boostStrength = 50;
    public float boostDuration = 4;
    public float boostCharge = 10;
    private float boostTimerD = 0;
    private float boostTimerC = 0;
    private bool boost = false;
    public float forwardForce = 5;
    public float sidewaysForce = 50;

    private Rigidbody rb;


    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }



    private void FixedUpdate()
    {

        if (boost == false)
        {
            boostTimerC = boostTimerC + Time.deltaTime;
        }
        if (boost)
        {
            rb.AddForce(transform.forward * boostStrength * 60 * Time.deltaTime);
            boostTimerD = boostTimerD + Time.deltaTime;
            if (boostTimerD >= boostDuration)
            {
                boost = false;
                boostTimerD = 0;
            }
        }        
        if ((boostTimerC >= boostCharge) & (keyManager.Boost()) & (boost == false))
        {
            boost = true;
            boostTimerC = 0;
        }




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




        rb.AddForce(transform.forward * forwardForce * 60 * Time.deltaTime);
        


    }
    
}
