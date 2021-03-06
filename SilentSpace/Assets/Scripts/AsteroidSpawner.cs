﻿using UnityEngine;
public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private GameObject asteroid;
    [SerializeField] private int numbAsteroids = 500;
    [SerializeField] private float spacing = 500;
    [SerializeField] private float size= 20;
    private float tmpsize;

    private GameObject ast;
    public GameObject asteroidContainer;
    private void Start()
    {
        asteroidContainer = new GameObject("AsteroidContainer");
        SpawnAsteroids(numbAsteroids, spacing, size);
    }
    void SpawnAsteroids(int numberAsterorids, float spacing, float size)
    {
        int i = 0;
        while (i < numberAsterorids)
        {
            tmpsize = size*Random.Range(0.5f, 2f); 

            Vector3 position = new Vector3(spacing * NextGaussian(), spacing * NextGaussian(), spacing * NextGaussian()); ;
            Quaternion rotation = new Quaternion(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));
            Vector3 scale = new Vector3(tmpsize, tmpsize, tmpsize); ;
            ast = Instantiate(asteroid, asteroidContainer.transform);
            
            ast.transform.rotation = rotation;
            ast.transform.position = position;
            ast.transform.localScale = scale;
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
