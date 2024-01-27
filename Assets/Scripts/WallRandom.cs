using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRandom : MonoBehaviour

{
    public GameObject objetoAleatorio; 
    public float xRange = 10.0f; 
    public float yRange = 10.0f; 
    public float zRange = 10.0f;
    public int CantidadDeveces = 2;
    void Start()
    {
        
        for (int i = 0; i < CantidadDeveces; i++)
        {
            PlaceObjectRandomly();
        }
    }

    void PlaceObjectRandomly()
    {
        float x = Random.Range(-xRange, xRange);
        float y = Random.Range(-yRange, yRange);
        float z = Random.Range(-zRange, zRange);

        Vector3 randomPosition = new Vector3(x, y, z);
        Instantiate(objetoAleatorio, randomPosition, Quaternion.identity);
    }
}


