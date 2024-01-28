using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCaracter : MonoBehaviour
{
    public float fuerzaSalto = 10f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }
    }
    //Revisar Salto
    private void Saltar()
    {
        rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
    }
}
