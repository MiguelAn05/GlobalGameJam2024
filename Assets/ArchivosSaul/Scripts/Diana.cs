using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diana : MonoBehaviour
{
    public float velocidad = 2.0f;  // Velocidad de movimiento de la plataforma
    public float limiteSuperior = 5.0f;  // Posici?n m?s alta de la plataforma
    public float limiteInferior = -5.0f;  // Posici?n m?s baja de la plataforma

    private bool subiendo = true;  // Bandera para determinar si la plataforma est? subiendo o bajando

    void Update()
    {
        // Mover la plataforma hacia arriba o hacia abajo
        if (subiendo)
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
        }

        // Cambiar la direcci?n cuando se alcanza un l?mite
        if (transform.position.y >= limiteSuperior)
        {
            subiendo = false;
        }
        else if (transform.position.y <= limiteInferior)
        {
            subiendo = true;
        }
    }

    // M?todo llamado cuando un objeto colisiona con la plataforma
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))  // Reemplaza "TuTagDeObjeto" con el tag de tu objeto
        {
            PlayerPrefs.SetInt("gameOver", 1);

            SceneManager.LoadScene("GameOver", 0);
        }
    }
}
