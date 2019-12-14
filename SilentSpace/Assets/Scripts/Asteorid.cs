﻿using UnityEngine;
public class Asteorid : MonoBehaviour
{
    private bool b = true;
    [SerializeField] private GameObject destroyedAstroid;
    [SerializeField] private float health = 1000;
    [SerializeField] private GameObject parAsteorid;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Shot")
        {
            health -= 334;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Player")
        {
            health = 0;
        }
    }
    void Update()
    {
        if ((health <= 0) & b)
        {
            GameObject dast;
            dast = Instantiate(destroyedAstroid, parAsteorid.transform);
            dast.transform.position = transform.position;
            dast.transform.rotation = transform.rotation;
            dast.transform.localScale = transform.localScale;

            Debug.Log("Scale Asteroid" + transform.localScale);

            Destroy(gameObject);            
        }
    }
}