using System.Collections;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    
    public float fuerzaSalto = 10f;
    public int totales;
    public float velocity = 2.4f;
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.velocity = Vector2.up * velocity;
        }
    }
}

