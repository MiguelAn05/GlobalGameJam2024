using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float Speed = 0.5f ;
    [SerializeField] private MeshRenderer mesh;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * Speed); 
        mesh.material.mainTextureOffset = offset;
    }

    
}
