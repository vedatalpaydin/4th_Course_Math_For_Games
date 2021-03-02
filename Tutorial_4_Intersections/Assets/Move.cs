using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform start;

    public Transform end;

    private Line line;
    // Start is called before the first frame update
    void Start()
    {
        line = new Line(new Coords(start.position),new Coords(end.position));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = line.GetPointAt(Time.time).ToVector();
    }
}
