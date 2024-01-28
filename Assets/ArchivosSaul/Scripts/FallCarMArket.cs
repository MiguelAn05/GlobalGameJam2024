using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCarMArket : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false); // Desactivar el objeto al inicio
    }

    public void ActivateRock()
    {
        gameObject.SetActive(true); // Activar el objeto
    }
}
