using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float Speed;
    public Animator animator;
    public GameObject[] character;
    public SaltoParabolico points;
    public Rigidbody2D fly;
    private int impulse = 5;


    void Start()
    {
        animator = GetComponent<Animator>();
        character[0].SetActive(false);
        character[1].SetActive(false);
        Invoke("ActivateAnimation", 7.0f);

    }

    void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * movement * Speed * Time.deltaTime);
        character[0].transform.position = transform.position;
        character[1].transform.position = new Vector2(transform.position.x + 2f,transform.position.y + 2f);
        

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
            fly.velocity = new Vector2(fly.velocity.x * impulse, impulse);
        }

        
     }
    void ActivateAnimation()
    {
        int randomAnimation = Random.Range(0, 2);
        
        if (randomAnimation==0)
        {
                animator.SetBool("Action1", true);
        }
        if (randomAnimation == 1)
        {
                animator.SetBool("Action2", true);
        }
        
    }
}   



