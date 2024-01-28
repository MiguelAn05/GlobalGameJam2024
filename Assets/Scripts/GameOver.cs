using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    int isFine;
    public TMP_Text textToChange;

    // Start is called before the first frame update
    void Start()
    {
        isFine = PlayerPrefs.GetInt("selectedCharacter");

        if (isFine == 1)
        {
            textToChange.text = "You nail it"; 
        }
        else
        {
            textToChange.text = "You fail it";
        }
    }
}
