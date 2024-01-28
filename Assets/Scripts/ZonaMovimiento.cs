using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMovimiento : MonoBehaviour
{
    public float velocidad;
    private bool dentroDelTrigger = false;

    void Update()
    {
        if (dentroDelTrigger)
        {
            float movimientoH = Input.GetAxis("Horizontal");
            
            Vector2 movimiento = new Vector2(movimientoH,0);

            // Aplica el movimiento al jugador
            transform.position = new Vector2(
                transform.position.x + movimiento.x * velocidad * Time.deltaTime,0
               
            );
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            // Cuando el jugador entra en el trigger, se le permite moverse
            dentroDelTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            // Cuando el jugador sale del trigger, se le impide moverse
            dentroDelTrigger = false;
        }
    }



}
