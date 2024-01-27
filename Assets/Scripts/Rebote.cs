using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebote : MonoBehaviour
{

    public float impulse;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collision"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, impulse), ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
