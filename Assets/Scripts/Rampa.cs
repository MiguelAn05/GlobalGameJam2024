using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoYrampa : MonoBehaviour
{
    [Range(0, 100)]
    public float piso;
    public GameObject player;
    public Rigidbody rb;

    // Start is called before the first frame update
    private void Awake()
    {
        Debug.DrawLine(player.transform.position, new Vector3(-4f, -5f, 0), Color.red);
        
    }
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position == new Vector3(-4f, -5f, 0))
        {
            if (Input.GetKey("space"))
            {
                rb = GetComponent<Rigidbody>();
                rb.mass--;
                print("space key was pressed");
            }
        }
    }
}
