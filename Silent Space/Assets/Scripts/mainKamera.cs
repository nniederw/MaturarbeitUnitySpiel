using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainKamera : MonoBehaviour
{
    public GameObject target;
    public float distanceDamp = 10f;
    public float rotationDamp = 10f;
    public Vector3 defaltDistance = new Vector3(0f, 2f, -10f);

    private Vector3 AimPos;
    private Quaternion AimRot;
    


    private void Update()
    {
        AimPos = target.transform.position + (target.transform.rotation * defaltDistance);  //Calculation of the aim position
        transform.position = Vector3.Slerp(transform.position, AimPos, Time.deltaTime*distanceDamp);        //Apply this aim position with a damp

        AimRot = Quaternion.LookRotation(target.transform.position - transform.position, target.transform.up);  //Calculation of the aim rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, AimRot, rotationDamp * Time.deltaTime);       //Apply this aim rotation with a damp


    }
}