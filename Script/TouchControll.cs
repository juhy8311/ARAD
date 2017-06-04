using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControll : MonoBehaviour
{
    public GameObject car;
    float speed = 0.4f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                float x = Input.GetTouch(0).deltaPosition.x;
                float y = Input.GetTouch(0).deltaPosition.y;
                car.transform.rotation *= Quaternion.AngleAxis(x * speed, Vector3.up);
                car.transform.rotation *= Quaternion.AngleAxis(y * speed, Vector3.right);
            }
        }
    }
    
}