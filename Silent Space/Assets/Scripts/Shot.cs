using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public float ShotSpeed = 50;
    Rigidbody rb;
     void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * ShotSpeed, ForceMode.Impulse);
    }

}
