using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorJKL : MonoBehaviour
{
    public GameObject[] j;
    public GameObject[] k;
    public GameObject[] l;

    private float timeJKL;
    public float starTime;
    
    void Start()
    {
        timeJKL = starTime; 
    }

    
    void Update()
    {
        timeJKL -= Time.deltaTime;

        if (timeJKL <= 0)
        {
            
            int randomIndex = Random.Range(0, 3);
            GameObject[] prefabs = { j[Random.Range(0, j.Length)], k[Random.Range(0, k.Length)], l[Random.Range(0, l.Length)] };
            Instantiate(prefabs[randomIndex], transform.position, Quaternion.identity);

            timeJKL = starTime; 
        }
    }
}
