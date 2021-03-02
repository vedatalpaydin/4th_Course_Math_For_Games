using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform start;

    public Transform end;

    //private Line line;
    // Start is called before the first frame update
    void Start()
    {
        //line = new Line(new Coords(start.position),new Coords(end.position),Line.LINETYPE.SEGMENT);
    }

    // Update is called once per frame
    void Update()
    {
      //  transform.position = line.Lerp(Time.time*0.5f).ToVector();
      transform.position = HolisticMath.Lerp(new Coords(start.position), new Coords(end.position), Time.time * 0.1f).ToVector();
    }
}
