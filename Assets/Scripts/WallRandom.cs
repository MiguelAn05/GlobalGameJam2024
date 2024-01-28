using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRandom : MonoBehaviour

{
    public GameObject[] objetoAleatorio;
    public float distancia = 10.0f;
    public int CantidadDeveces = 2;

    void Start()
    {
        Vector3 posicionInicial = new Vector3(20, 0, 0);

        for (int i = 0; i < CantidadDeveces; i++)
        {
            posicionInicial.y = Random.Range(Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y);
            PlaceObjectRandomly(posicionInicial);
            posicionInicial.x += distancia;
        }
    }

    void PlaceObjectRandomly(Vector3 posicion)
    {
        int randomIndex = Random.Range(0, objetoAleatorio.Length);
        Instantiate(objetoAleatorio[randomIndex], posicion, Quaternion.identity);
    }

}


