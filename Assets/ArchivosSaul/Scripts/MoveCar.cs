using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float Speed;
    public Animator animator;
    public GameObject[] character;
    

    void Start()
    {
        animator = GetComponent<Animator>();
        character[0].SetActive(false);
        character[1].SetActive(false);
        

    }

    void Update()
    {
        float movement = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * movement * Speed * Time.deltaTime);
        character[0].transform.position = transform.position;
        character[1].transform.position = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            character[0].SetActive(true);
            character[1].SetActive(true);
            gameObject.SetActive(false);
        }

     }

    
}   



