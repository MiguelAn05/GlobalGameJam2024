using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public Transform objetivo; // Referencia al transform del personaje que seguir? la c?mara
    public float suavizado = 5f; // Controla la velocidad de seguimiento de la c?mara

    private void LateUpdate()
    {
        if (objetivo != null)
        {
            // Calcula la posici?n deseada de la c?mara
            Vector3 posicionDeseada = new Vector3(objetivo.position.x+8, objetivo.position.y, transform.position.z);

            // Usa la funci?n Lerp para suavizar el movimiento de la c?mara
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavizado * Time.deltaTime);
        }
    }
}
