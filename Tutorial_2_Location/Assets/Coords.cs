using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coords
{
   private float x, y, z;

   public Coords(float _X, float _Y)
   {
      x = _X;
      y = _Y;
      z = -1;
   }

   public override string ToString()
   {
      return "(" + x + "," + y + "," + z + ")";
   }

   static public void DrawPoint(Coords position, float width, Color color)
   {
      GameObject line = new GameObject("Point_" + position.ToString());
      LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
      lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
      lineRenderer.material.color = color;
      lineRenderer.positionCount = 2;
      lineRenderer.SetPosition(0,new Vector3(position.x-width/3.0f,position.y-width/3.0f,position.z));
      lineRenderer.SetPosition(1,new Vector3(position.x+width/3.0f,position.y+width/3.0f,position.z));
      lineRenderer.startWidth = width;
      lineRenderer.endWidth = width;
   }

   static public void DrawLine(Coords startPosition,Coords endPosition, float width, Color color)
   {
      GameObject line = new GameObject("Point_" + startPosition.ToString());
      LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
      lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
      lineRenderer.material.color = color;
      lineRenderer.positionCount = 4;
      lineRenderer.SetPosition(0,new Vector3(startPosition.x-width,startPosition.y-width,startPosition.z));
      lineRenderer.SetPosition(1,new Vector3(startPosition.x+width,startPosition.y+width,startPosition.z));
      lineRenderer.SetPosition(2,new Vector3(endPosition.x-width,endPosition.y-width,endPosition.z));
      lineRenderer.SetPosition(3,new Vector3(endPosition.x+width,endPosition.y+width,endPosition.z));
      lineRenderer.startWidth = width;
      lineRenderer.endWidth = width;
   }
}
