using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probe : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        // Obtener el componente Animator del GameObject
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            // Activar la animación de mover hacia la derecha
            animator.SetBool("Walk", true);
        }
        else
        {
            // Desactivar la animación de mover hacia la derecha
            animator.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            // Activar la animación de mover hacia la derecha
            animator.SetTrigger("Jump");
        }
        

        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Activar la animación especial asociada a la tecla F
            animator.SetTrigger("Action1");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            // Activar la animación especial asociada a la tecla F
            animator.SetTrigger("Action2");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            // Activar la animación especial asociada a la tecla F
            animator.SetTrigger("Action3");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            // Activar la animación especial asociada a la tecla F
            animator.SetTrigger("Action4");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            // Activar la animación especial asociada a la tecla F
            animator.SetTrigger("Floor");
        }
       
    }
}
