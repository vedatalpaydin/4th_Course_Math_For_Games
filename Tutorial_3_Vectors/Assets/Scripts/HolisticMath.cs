﻿using System;
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
        float diffSquared = Square(point1.x - point2.x) + Square(point1.y - point2.y) + Square(point1.z - point2.z);
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

    static public float Angle(Coords vector1, Coords vector2)
    {
        float dotDivide = Dot(vector1, vector2) / (Distance(new Coords(0, 0, 0), vector1) *
                                                   Distance(new Coords(0, 0, 0), vector2));
        return Mathf.Acos(dotDivide); //radians. for degree *180/Mathf.PI;
    }

    static public Coords Rotate(Coords vector, float angle, bool clockwise) // radians...
    {
        if (clockwise)
        {
            angle = 2 * Mathf.PI - angle;
        }

        float xVal = vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sin(angle);
        float yVal = vector.x * Mathf.Sin(angle) + vector.y * Mathf.Cos(angle);
        return new Coords(xVal, yVal, 0);
    }

    static public Coords Cross(Coords vector1, Coords vector2)
    {
        float xMult = vector1.y * vector2.z - vector1.z * vector2.y;
        float yMult = vector1.z * vector2.x - vector1.x * vector2.z;
        float zMult = vector1.x * vector2.y - vector1.y * vector2.x;
        Coords crossProd = new Coords(xMult, yMult, zMult);
        return crossProd;
    }

    static public Coords LookAt2D(Coords forwardVector, Coords position, Coords target)
    {
        Coords direction = new Coords(target.x - position.x, target.y - position.y, position.z);
        float angle = Angle(forwardVector, direction);
        bool clockwise = Cross(forwardVector, direction).z < 0;
        Coords newDir = Rotate(forwardVector, angle, clockwise);
        return newDir;
    }
}