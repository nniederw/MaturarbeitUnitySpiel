using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotManager : MonoBehaviour
{
    [SerializeField] private GameObject shot;
    private Vector3 offset0 = new Vector3(3.51f, 1.02f, 3.76f);
    private Vector3 offset1 = new Vector3(-3.51f, 1.02f, 3.76f);
    private double timer = 0;
    [SerializeField] private double delay = 1;
    [SerializeField] private float energyCost = 50;

    private void Update()
    {
        timer += Time.deltaTime;
        if (keyManager.Shoot() & (timer >= delay)&(variables.LeftEnergy() >= energyCost))
        {
            variables.AddEnergy(energyCost);
            Instantiate(shot, transform.position + transform.rotation * offset0, transform.rotation);
            Instantiate(shot, transform.position + transform.rotation * offset1, transform.rotation);
            timer = 0;
        }
    }
}
