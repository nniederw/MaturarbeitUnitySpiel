using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotManager : MonoBehaviour
{
    public GameObject shot;
    Vector3 offset0 = new Vector3(3.51f, 1.02f, 3.76f);
    Vector3 offset1 = new Vector3(-3.51f, 1.02f, 3.76f);


    void Update()
    {
        if (keyManager.Shoot()) {

            Instantiate(shot, transform.position + transform.rotation*offset0, transform.rotation);
            Instantiate(shot, transform.position + transform.rotation * offset1, transform.rotation);

        }

    }
}
