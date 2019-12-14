﻿using UnityEngine;
public class mainKamera : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float distanceDamp = 5;
    [SerializeField] private float rotationDamp = 4;
    [SerializeField] private Vector3 defaltDistance = new Vector3(0, 6, -15);

    private Vector3 AimPos;
    private Quaternion AimRot;
    
    private void Update()
    {
        AimPos = target.transform.position + (target.transform.rotation * defaltDistance);  
        transform.position = Vector3.Slerp(transform.position, AimPos, Time.deltaTime*distanceDamp);

        AimRot = Quaternion.LookRotation(target.transform.position - transform.position, target.transform.up);  
        transform.rotation = Quaternion.Lerp(transform.rotation, AimRot, rotationDamp * Time.deltaTime);      
    }
}