using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
    // private Coords point = new Coords(10,20);

    private Coords startPointXAxis = new Coords(0, 100);
    private Coords endPointXAxis = new Coords(0, -100);
    private Coords starPointYAxis = new Coords(160, 0);
    private Coords endPointYAxis = new Coords(-160, 0);

    private Coords[] sagitarius =
    {
        new Coords(0, 50),
        new Coords(10, 15),
        new Coords(15, 2),
        new Coords(20, 7),
        new Coords(22, 1),
        new Coords(2, 52),
        new Coords(10, 60),
        new Coords(22, 55),
        new Coords(25, 59),
        new Coords(20, 70),
        new Coords(22, 74),
        new Coords(17, 68),
        new Coords(10, 80),
        new Coords(30, 52),
        new Coords(35, 55),
        new Coords(40, 58),
        new Coords(45, 70),
        new Coords(45, 52),
        new Coords(48, 50),
        new Coords(49, 52),
        new Coords(55, 60),
        new Coords(50, 40),
        new Coords(53, 38),
    };

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(point.ToString());
        //Coords.DrawPoint(new Coords(0,0),2,Color.red);
        //Coords.DrawPoint(point,2,Color.green);
        Coords.DrawLine(startPointXAxis, endPointXAxis, 1, Color.green);
        Coords.DrawLine(starPointYAxis, endPointYAxis, 1, Color.red);
        foreach (Coords c in sagitarius)
        {
            Coords.DrawPoint(c, 2, Color.yellow);
        }

        Coords.DrawLine(sagitarius[0], sagitarius[1], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[1], sagitarius[2], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[2], sagitarius[3], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[2], sagitarius[4], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[0], sagitarius[5], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[5], sagitarius[6], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[6], sagitarius[7], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[7], sagitarius[8], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[8], sagitarius[9], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[9], sagitarius[10], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[9], sagitarius[11], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[11], sagitarius[12], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[7], sagitarius[13], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[8], sagitarius[14], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[13], sagitarius[14], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[14], sagitarius[15], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[15], sagitarius[16], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[15], sagitarius[17], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[17], sagitarius[18], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[18], sagitarius[19], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[19], sagitarius[20], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[17], sagitarius[21], 0.4f, Color.white);
        Coords.DrawLine(sagitarius[21], sagitarius[22], 0.4f, Color.white);
    }

    // Update is called once per frame
    void Update()
    {
    }
}