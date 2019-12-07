using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    [SerializeField] private float wakingSpeed = 10;
    [SerializeField] private float mousePositionX = 0;

    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (keyManager.GoUp())
        {
            rb.AddForce(transform.forward * wakingSpeed);
        }
        if (keyManager.GoDown())
        {
            rb.AddForce(transform.forward * -1 * wakingSpeed);
        }
        if (keyManager.GoLeft())
        {
            rb.AddForce(transform.right * -1 * wakingSpeed);
        }
        if (keyManager.GoRight())
        {
            rb.AddForce(transform.right * wakingSpeed);
        }
        //if(Input.mousePosition)
        mousePositionX = Input.mousePosition.x;




    }
}
