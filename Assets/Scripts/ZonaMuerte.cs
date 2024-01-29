using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ZonaMuerte : MonoBehaviour
{
    public Rigidbody2D rb;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            print("se murio");
            PlayerPrefs.SetInt("gameOver", 0);

            SceneManager.LoadScene("GameOver", 0);
        }

    }
 
}


