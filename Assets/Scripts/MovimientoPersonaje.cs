using System.Collections;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public float fuerzaSalto = 10f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
        
    }
}
