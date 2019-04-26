using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotManager : MonoBehaviour
{
    public GameObject shot;


    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (keyManager.Shoot()) {

            Instantiate(shot, transform.position, transform.rotation);

        }
        
    }
}
