using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText; // Asigna tu objeto TextMeshProUGUI desde el Inspector

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Puntuación actual: " + score);
        UpdateUI();
    }

    void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Puntuación: " + score;
        }
    }
}

