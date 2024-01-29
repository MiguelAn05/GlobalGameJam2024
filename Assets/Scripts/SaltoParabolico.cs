using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoParabolico : MonoBehaviour
{
    public float jumpForce = 5.0f;
    public float horizontalForce = 2.0f;
    private Rigidbody2D rb;
    public int puntaje;
    private int impulse;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Salto hacia arriba
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            // Componente horizontal
            rb.AddForce(Vector2.right * horizontalForce, ForceMode2D.Impulse);
            puntaje ++;
        }

        if (puntaje == 10)
        {

            
        }

        // Opcional: Reiniciar la bandera de salto cuando aterriza (por ejemplo, cuando la posici?n y es inferior a cierto umbral)
        
    }
    
}
