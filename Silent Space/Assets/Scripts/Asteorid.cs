using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            dast.transform.localScale = transform.localScale;
            Destroy(gameObject);            
        }
    }
}