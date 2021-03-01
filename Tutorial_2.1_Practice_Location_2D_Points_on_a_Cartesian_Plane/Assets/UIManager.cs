using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject tank;

    public GameObject fuel;

    public Text tankPos;

    public Text fuelPos;

    // Start is called before the first frame update
    void Start()
    {
        tankPos.text = tank.transform.position+"";
    }

    // Update is called once per frame
    void Update()
    {
    }
}