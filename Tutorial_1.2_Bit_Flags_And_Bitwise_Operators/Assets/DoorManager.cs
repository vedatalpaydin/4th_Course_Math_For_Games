using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    private int doorType = 0;

    private void OnCollisionEnter(Collision other)
    {
        if ((other.gameObject.GetComponent<AttributeManager>().attributes & doorType) == doorType)
        {
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<BoxCollider>().isTrigger = false;
        other.gameObject.GetComponent<AttributeManager>().attributes &= ~doorType;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "BLUEDOOR") doorType = AttributeManager.BLUEKEY;
        if (gameObject.tag == "REDDOOR") doorType = AttributeManager.REDKEY;
        if (gameObject.tag == "PURPLEDOOR") doorType = (AttributeManager.BLUEKEY | AttributeManager.REDKEY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
