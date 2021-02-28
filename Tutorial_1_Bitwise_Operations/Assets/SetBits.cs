using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBits : MonoBehaviour
{
    private int bSequence = 8+1+2;
    void Start()
    {
        Debug.Log(Convert.ToString(bSequence,2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
