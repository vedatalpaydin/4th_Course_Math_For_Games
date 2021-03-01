using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject tank;

    public GameObject fuel;

    public Text tankPos;

    public Text fuelPos;
    public Text energyAmount;

    public void AddEnergy(string amt)
    {
        int n;
        if (int.TryParse(amt,out n))
        {
            energyAmount.text = amt;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        tankPos.text = tank.transform.position+"";
        fuelPos.text = fuel.GetComponent<ObjectManager>().objPos + "";
    }

    // Update is called once per frame
    void Update()
    {
    }
}