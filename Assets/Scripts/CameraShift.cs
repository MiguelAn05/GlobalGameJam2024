using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShift : MonoBehaviour
{
    public Camera cam;
    public float zoomSpeed = 5.0f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            cam.orthographicSize = Mathf.MoveTowards(cam.orthographicSize, 5.0f, zoomSpeed * Time.deltaTime);
        }
    }
}
