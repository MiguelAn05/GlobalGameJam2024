using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public Transform objetivo; // Referencia al transform del personaje que seguirá la cámara
    public float suavizado = 5f; // Controla la velocidad de seguimiento de la cámara

    private void LateUpdate()
    {
        if (objetivo != null)
        {
            // Calcula la posición deseada de la cámara
            Vector3 posicionDeseada = new Vector3(objetivo.position.x+8f, objetivo.position.y*0, transform.position.z);

            // Usa la función Lerp para suavizar el movimiento de la cámara
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavizado * Time.deltaTime);
        }
    }
}
