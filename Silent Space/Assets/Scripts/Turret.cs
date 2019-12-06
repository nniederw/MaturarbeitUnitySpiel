using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private GameObject Target;
    [SerializeField] private GameObject shot;

    private float timer = 0;
    private Vector3 oldPosition;
    private Vector3 currPosition;
    private Vector3 currVelocity;
    private float bulletSpeed = 10;
    private float distanceToPlayer;

    void Start()
    {
        oldPosition = Target.transform.position;
        currPosition = Target.transform.position;
        distanceToPlayer = Vector3.Distance(currPosition,transform.position);
    }

    void Update()
    {
        timer += Time.deltaTime;

        currPosition = Target.transform.position;
        currVelocity = (currPosition - oldPosition) * Time.deltaTime;


        transform.LookAt(NewPlayerPosition(distanceToPlayer));
        //transform.LookAt(currPosition);
                if (timer >= 0.5) { 
        Instantiate(shot, transform.position + transform.forward*1, transform.rotation);
            timer -= 0.5f;
        }
        oldPosition = Target.transform.position;

        
    }




    Vector3 NewPlayerPosition(float distanceToTarget) {
        float _time = distanceToTarget / bulletSpeed;
        return _time * currVelocity;
    }
}
