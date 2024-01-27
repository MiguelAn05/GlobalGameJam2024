using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rampa : Combos
{
    [Range(0, 100)]
    public float piso;
    public Rigidbody2D rb;
    private float graviti = -10f;
    private float graviti2 = 1;
    private bool isJumping = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            print("Espacio");
            if (Input.GetKey(KeyCode.Space))
            {
                isJumping = true;
                rb.gravityScale = graviti;
                rb.velocity = new Vector2(rb.velocity.x, piso);
                print("saltar");
            }
        }
    }

    private void Update()
    {
        if (isJumping && rb.velocity.y >= 0)
        {
            isJumping = false;
            rb.gravityScale = Mathf.Abs(graviti2++); // Restaura la gravedad normalizando su valor absoluto
        }
    }
}