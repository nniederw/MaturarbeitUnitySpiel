using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    
    [SerializeField] private float ShotSpeed = 50;
    [SerializeField] private float Livetime = 20;

    public Vector3 SummonVelocity = new Vector3 (0,0,0);
    public float damage = 0;
    public bool damagePlayer = false;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = SummonVelocity;
        rb.AddForce(transform.forward * ShotSpeed, ForceMode.Impulse);
    }

    private void Update()
    {
        Destroy(gameObject, Livetime);
    }   
}
