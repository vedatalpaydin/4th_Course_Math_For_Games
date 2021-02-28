using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    private int doorType = AttributeManager.MAGIC;

    private void OnCollisionEnter(Collision other)
    {
        if ((other.gameObject.GetComponent<AttributeManager>().attributes & doorType) != 0)
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<BoxCollider>().isTrigger = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
