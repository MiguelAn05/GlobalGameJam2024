using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleObject : MonoBehaviour
{
    public float jumpForce = 400.0f;
    public float horizontalForce = 900.0f;
    private Rigidbody2D rb;
    void OnBecameVisible()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);

        // Componente horizontal (puedes ajustar la direcci?n seg?n tus necesidades)
        rb.AddForce(Vector3.forward * horizontalForce, ForceMode2D.Impulse);
    }
}
