using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jiwoo0 : MonoBehaviour
{

    public float rotationSpeed = 10.0f;
    public float lerpSpeed = 1.0f;

    private Vector3 speed = new Vector3();
    private Vector3 avgSpeed = new Vector3();
    private bool dragging = false;

    void OnMouseDown()
    {
        dragging = true;
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && dragging)
        {
            speed = new Vector3(-Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
            avgSpeed = Vector3.Lerp(avgSpeed, speed, Time.deltaTime * 2);
        }
        else
        {
            if (dragging)
            {
                speed = avgSpeed;
                dragging = false;
            }

            float i = Time.deltaTime * lerpSpeed;
            speed = Vector3.Lerp(speed, Vector3.zero, i);
        }

        transform.Rotate(Camera.main.transform.up * speed.x * rotationSpeed, Space.World);
        transform.Rotate(Camera.main.transform.right * speed.y * rotationSpeed, Space.World);
    }
}