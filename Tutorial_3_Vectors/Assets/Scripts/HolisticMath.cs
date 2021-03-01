using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolisticMath
{
    static public Coords GetNormal(Coords vector)
    {
        float lenght = Distance(new Coords(0, 0, 0), vector);
        vector.x /= lenght;
        vector.y /= lenght;
        vector.z /= lenght;

        return vector;
    }

    static public float Distance(Coords point1, Coords point2)
    {
        float diffSquared = Square(point1.x - point2.x) + Square(point1.y - point2.y)+Square(point1.z - point2.z);
        float squareRoot = Mathf.Sqrt(diffSquared);
        return squareRoot;
    }

    static public float Square(float value)
    {
        return value * value;
    }

    static public float Dot(Coords vector1, Coords vector2)
    {
        return (vector1.x * vector2.x + vector1.y * vector2.y);
    }

    static public float Angle(Coords vector1,Coords vector2)
    {
        float dotDivide = Dot(vector1, vector2) / (Distance(new Coords(0, 0, 0), vector1) *
                          Distance(new Coords(0, 0, 0), vector2));
        return Mathf.Acos(dotDivide); //radians. for degree *180/Mathf.PI;
    }

    static public Coords Rotate(Coords vector, float angle) // radians...
    {
        float xVal = vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sign(angle);
        float yVal = vector.x * Mathf.Sin(angle) + vector.y * Mathf.Cos(angle);
        return new Coords(xVal, yVal,0);
    } 
}
