using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    private int score = 0;
    public TMP_Text puntaje; // Asigna tu objeto TextMeshProUGUI desde el Inspector

    void Update()
    {
        CheckInput();
        UpdateUI();
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddScore(50);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            AddScore(20);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            AddScore(60);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            AddScore(10);
        }
    }

    void AddScore(int points)
    {
        score += points;
        Debug.Log("Puntuación actual: " + score);
    }

    void UpdateUI()
    {
        if (puntaje != null)
        {
            puntaje.text = "Puntuación: " + score;
        }
    }
}

  