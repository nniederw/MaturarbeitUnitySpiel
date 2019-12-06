using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject tes;
    void Start()
    {
        
    }

    void Update()
    {
        transform.LookAt(tes.transform.position);   
    }
}
