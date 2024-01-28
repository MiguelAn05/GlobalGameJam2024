using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoParabolico : MonoBehaviour
{
    public float jumpForce = 5.0f;
    public float horizontalForce = 2.0f;
    private Rigidbody2D rb;
    private bool hasJumped = false;
    private int puntaje;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        if (Input.GetKeyDown("w") && !hasJumped)
        {
            // Salto hacia arriba
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);

            // Componente horizontal (puedes ajustar la dirección según tus necesidades)
            rb.AddForce(Vector3.forward * horizontalForce, ForceMode2D.Impulse);
            puntaje ++;
        }

        if (puntaje == 10)
        {
            
        }

        // Opcional: Reiniciar la bandera de salto cuando aterriza (por ejemplo, cuando la posición y es inferior a cierto umbral)
        
    }
    
}
