using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private float ShotSpeed = 50;
    [SerializeField] private float Livetime = 30;
    private Rigidbody rb;
     private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * ShotSpeed, ForceMode.Impulse);
        

}
    private void Update()
    {
        Destroy(gameObject, Livetime);
        
    }

}
