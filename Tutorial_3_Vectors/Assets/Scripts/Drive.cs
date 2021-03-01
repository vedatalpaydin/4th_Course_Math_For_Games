using System;
using UnityEngine;

public class Drive : MonoBehaviour
{
    private float speed = 5;
    public GameObject fuel;
    private Vector3 dir;
    private float stoppingDist = 0.1f;

    private void Start()
    {
        dir = fuel.transform.position - transform.position;
        Coords dirNormal = HolisticMath.GetNormal(new Coords(dir));
        dir = dirNormal.ToVector();
        float a = HolisticMath.Angle(new Coords(0, 1, 0), new Coords(dir)) * 180.0f/Mathf.PI;
        Debug.Log("Angle to fuel: " + a);
    }

    void Update()
    {
        if (HolisticMath.Distance(new Coords(transform.position), new Coords(fuel.transform.position)) > stoppingDist)
            transform.position += dir * speed * Time.deltaTime;
    }
}