using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    int isFine;
    public TMP_Text textToChange;
    public Image imageTarget;

    // Start is called before the first frame update
    void Start()
    {
        isFine = PlayerPrefs.GetInt("gameOver");

        if (isFine == 1)
        {
            textToChange.text = "You nailed it";
            imageTarget.enabled = true;
        }
        else
        {
            textToChange.text = "You failed";
            imageTarget.enabled = false;

        }
    }
}
