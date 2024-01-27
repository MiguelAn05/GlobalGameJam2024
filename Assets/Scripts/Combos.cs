using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combos : MonoBehaviour
{
    public ScoreManager scoreManager; // Asigna tu objeto ScoreManager desde el Inspector
    //asignar objetos ScoreManager y ComboManager desde el Inspector de Unity.

    public void CheckCombo(string combo)
    {
        switch (combo)
        {
            case "J":
                ExecuteCombo(scoreManager, 10, 25, "AnimacionComboJJ");
                break;
            case "JK":
                ExecuteCombo(scoreManager, 25, 35, "AnimacionComboJK");
                break;
            case "JL":
                ExecuteCombo(scoreManager, 35, 50, "AnimacionComboJL");
                break;
            case "KJ":
                ExecuteCombo(scoreManager, 25, 35, "AnimacionComboKJ");
                break;
            case "K":
                ExecuteCombo(scoreManager, 10, 25, "AnimacionComboKK");
                break;
            case "KL":
                ExecuteCombo(scoreManager, 35, 50, "AnimacionComboKL");
                break;
            case "LJ":
                ExecuteCombo(scoreManager, 25, 35, "AnimacionComboLJ");
                break;
            case "LK":
                ExecuteCombo(scoreManager, 35, 50, "AnimacionComboLK");
                break;
            case "L":
                ExecuteCombo(scoreManager, 10, 25, "AnimacionComboLL");
                break;
            default:
                Debug.Log("Combo no reconocido");
                break;
        }
    }

    void ExecuteCombo(ScoreManager scoreManager, int minPoints, int maxPoints, string animationName)
    {
        int points = Random.Range(minPoints, maxPoints + 1);
        scoreManager.AddScore(points);

        // Aquí puedes reproducir la animación específica para el combo
        Debug.Log("Animación: " + animationName);
    }
}
