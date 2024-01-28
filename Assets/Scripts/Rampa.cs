using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rampa : MonoBehaviour
{
    [Range(0, 100)]
    public float piso;
    public Rigidbody2D rb;
    private float graviti = -10f;
    private float graviti2 = 1;
    private bool isJumping = false;
   // public GameObject player;

    void Awake()
    {
        //rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            if (Input.GetKey(KeyCode.W))
            {
                isJumping = true;
                rb.gravityScale = graviti;
                rb.velocity = new Vector2(rb.velocity.x, piso);
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