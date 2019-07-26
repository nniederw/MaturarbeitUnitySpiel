using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainKamera : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float distanceDamp = 10f;
    [SerializeField] private float rotationDamp = 10f;
    [SerializeField] private Vector3 defaltDistance = new Vector3(0f, 2f, -10f);

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