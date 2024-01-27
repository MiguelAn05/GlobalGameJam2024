using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedKart;

    public void SelectCharacter(int cartType)
    {
        Debug.Log("entro");
        selectedKart = cartType;
        PlayerPrefs.SetInt("selectedCharacter", selectedKart);
        SceneManager.LoadScene("GameJam", LoadSceneMode.Single);
    }
}
