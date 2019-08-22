using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteoridBroken : MonoBehaviour
{
    public Vector3 scale = new Vector3(10, 10, 10);
    void Start()
    {
        transform.localScale = scale;
    }
}
