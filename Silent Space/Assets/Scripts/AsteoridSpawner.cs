using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteoridSpawner : MonoBehaviour
{
    [SerializeField] private GameObject asteorid;
    [SerializeField] private int numbAsteorids;
    [SerializeField] private float spacing;
    private void Start()
    {
        SpawnAsteorids(numbAsteorids, spacing);
    }




    void SpawnAsteorids(int numberAsteorids,float spacing) {

        
        
        int i = 0;
        while (i < numberAsteorids)
        {
            
            Vector3 position = new Vector3(spacing*NextGaussian(), spacing * NextGaussian(), spacing * NextGaussian()); ;
            Quaternion rotation = new Quaternion(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));
            Vector3 scale = new Vector3(spacing * NextGaussian(), spacing * NextGaussian(), spacing * NextGaussian()); ;
            transform.position = position;
            transform.rotation = rotation;
            transform.localScale = scale;
            Transform trans = transform;




            Instantiate(asteorid, position, rotation);
            i++;
        }
    }


    public static float NextGaussian()
{
    float v1, v2, s;
    do
    {

        v1 = 2.0f * Random.Range(0f, 1f) - 1.0f;
        v2 = 2.0f * Random.Range(0f, 1f) - 1.0f;
        s = v1 * v1 + v2 * v2;
    } while (s >= 1.0f || s == 0f);

    s = Mathf.Sqrt((-2.0f * Mathf.Log(s)) / s);

    return v1 * s;


}
}
