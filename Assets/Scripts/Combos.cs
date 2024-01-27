using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combos : MonoBehaviour
{
    public ScoreManager scoreManager; // Asigna tu objeto ScoreManager desde el Inspector
    //asignar objetos ScoreManager y ComboManager desde el Inspector de Unity.
    private int points1,points2,points3,points4;
    public int total = 75;

    public void CheckCombo(string combo)
    {

        switch (combo)
        {

            case "J":
                points1 = 10;
                points2 = 25;
                ExecuteCombo(scoreManager, points1, points2, "AnimacionComboJJ");
                break;
            case "JK":
                points3 = 35;
                points2 = 25;
                ExecuteCombo(scoreManager, points2, points3, "AnimacionComboJK");
                break;
            case "JL":
                points3 = 35;
                points4 = 50;
                ExecuteCombo(scoreManager, points3, points4, "AnimacionComboJL");
                break;
            case "KJ":
                points2 = 25;
                points3 = 35;
                ExecuteCombo(scoreManager, points2, points3, "AnimacionComboKJ");
                break;
            case "K":
                points1 = 10;
                points2 = 25;
                ExecuteCombo(scoreManager, points1, points2, "AnimacionComboKK");
                break;
            case "KL":
                points3 = 35;
                points4 = 50;
                ExecuteCombo(scoreManager, points3,points4, "AnimacionComboKL");
                break;
            case "LJ":
                points2 = 25;
                points3 = 35;
                ExecuteCombo(scoreManager, points2, points3, "AnimacionComboLJ");
                break;
            case "LK":
                points3 = 35;
                points4 = 50;
                ExecuteCombo(scoreManager, points3, points4, "AnimacionComboLK");
                break;
            case "L":
                points1 = 10;
                points2 = 25;
                ExecuteCombo(scoreManager, points1, points2, "AnimacionComboLL");
                break;
            default:
                Debug.Log("Combo no reconocido");
                break;
        }
    }

    void ExecuteCombo(ScoreManager scoreManager, int minPoints, int maxPoints, string animationName)
    {
        if (total > 75)
        {
            int points = Random.Range(minPoints, maxPoints + 1);
            scoreManager.AddScore(points);

            // Aquí puedes reproducir la animación específica para el combo
            Debug.Log("Animación: " + animationName);
            total = 0;
        }
        
        total = points1 + points2 + points3 + points3;
    }
}
