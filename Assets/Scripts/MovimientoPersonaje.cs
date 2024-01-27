using System.Collections;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    
    public float fuerzaSalto = 10f;
    public int totales;
    private void Awake()
    {
        
    }
    void Update()
    {
        Combos Points = GetComponent<Combos>();
        totales = Points.total;
 
        if (totales >= 75)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
        
    }
}
