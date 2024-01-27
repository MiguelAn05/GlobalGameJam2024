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

    // Start is called before the first frame update
    void Start()
    {
        timeJKL = starTime; // Iniciar el tiempo de espera
    }

    // Update is called once per frame
    void Update()
    {
        timeJKL -= Time.deltaTime; // Decrementar el tiempo de espera en cada frame

        if (timeJKL <= 0)
        {
            // Generar un GameObject aleatorio de j, k o l
            int randomIndex = Random.Range(0, 3);
            GameObject[] prefabs = { j[Random.Range(0, j.Length)], k[Random.Range(0, k.Length)], l[Random.Range(0, l.Length)] };
            Instantiate(prefabs[randomIndex], transform.position, Quaternion.identity);

            timeJKL = starTime; // Reiniciar el tiempo de espera
        }
    }
}
