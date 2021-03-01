﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
    private Coords point = new Coords(10,20);

    private Coords startPoint = new Coords(0, 100);

    private Coords endPoint = new Coords(0, -100);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(point.ToString());
        Coords.DrawPoint(new Coords(0,0),2,Color.red);
        Coords.DrawPoint(point,2,Color.green);
        Coords.DrawLine(startPoint,endPoint,1,Color.yellow);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
