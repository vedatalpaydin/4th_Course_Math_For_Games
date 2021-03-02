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
        float x = Input.GetAxis("Horizontal") *speed;
        float y = Input.GetAxis("VerticalY") *speed;
        float z = Input.GetAxis("Vertical") *speed;
       
        transform.Translate(x,y,z);
        
    }
}
