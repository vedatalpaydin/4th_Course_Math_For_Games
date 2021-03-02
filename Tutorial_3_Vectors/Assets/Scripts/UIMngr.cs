using UnityEngine;
using UnityEngine.UI;

public class UIMngr : MonoBehaviour
{
    public GameObject tank;

    public GameObject fuel;

    public Text tankPos;

    public Text fuelPos;
    public Text energyAmount;

    public void AddEnergy(string amt)
    {
        int n;
        if (int.TryParse(amt, out n))
        {
            energyAmount.text = amt;
        }
    }

    public void SetAngle(string amt)
    {
        float n;
        if (float.TryParse(amt, out n))
        {
            n *= Mathf.PI / 180.0f;
            tank.transform.up = HolisticMath.Rotate(new Coords(tank.transform.up), n, false).ToVector();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        tankPos.text = tank.transform.position + "";
        fuelPos.text = fuel.GetComponent<ObjectMngr>().objPos + "";
    }

    // Update is called once per frame
    void Update()
    {
    }
}