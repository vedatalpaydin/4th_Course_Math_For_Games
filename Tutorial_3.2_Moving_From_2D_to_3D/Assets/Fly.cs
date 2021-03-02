using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public float speed = 1.0f;
    void Start()
    {
        
    }

    void Update()
    {
        float xMove = Input.GetAxis("VerticalY") * speed;
        float x = Input.GetAxis("Vertical") *speed;
        float y = Input.GetAxis("Horizontal") *speed;
        float z = Input.GetAxis("HorizontalZ") *speed;
       
        transform.Translate(0,0,xMove);
        transform.Rotate(x,y,z);
        
    }
}
