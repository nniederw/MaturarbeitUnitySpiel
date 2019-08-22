﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteorid : MonoBehaviour
{
    private bool b = true;
    [SerializeField] private GameObject destroyedAstroid;
    [SerializeField] private float health = 1000;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Shot")
        {
            health -= 334;
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "Player")
        {
            health = 0;
        }
    }
    void Update()
    {


        if ((health <= 0) & b)
        {
            Instantiate(destroyedAstroid, transform.position, transform.rotation);
            destroyedAstroid.GetComponent<AsteoridBroken>().scale = transform.localScale;
            Destroy(gameObject);

        }
    }
}