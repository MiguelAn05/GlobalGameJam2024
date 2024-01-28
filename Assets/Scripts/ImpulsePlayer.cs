using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulsePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    private int impulse = 5; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
           
            rb.velocity = new Vector2(rb.velocity.x*impulse, impulse);
        }
    }


}
