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
        if (KeyManager.GoUp())
        {
            rb.AddForce(transform.forward * wakingSpeed);
        }
        if (KeyManager.GoDown())
        {
            rb.AddForce(transform.forward * -1 * wakingSpeed);
        }
        if (KeyManager.GoLeft())
        {
            rb.AddForce(transform.right * -1 * wakingSpeed);
        }
        if (KeyManager.GoRight())
        {
            rb.AddForce(transform.right * wakingSpeed);
        }
        //if(Input.mousePosition)
        mousePositionX = Input.mousePosition.x;




    }
}
