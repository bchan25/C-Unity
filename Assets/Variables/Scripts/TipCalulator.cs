using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalulator : MonoBehaviour
{
    public float totalBill;

    public float tipPercentage = 20.0f;

    private float tipAmount;
    private float totalBillAmount;


    // Start is called before the first frame update
    void Start()
    {
        tipAmount = totalBill * (tipPercentage / 100);
        totalBillAmount = totalBill + tipAmount;

        Debug.Log("Tip Amount: " + tipAmount.ToString("c2"));
        Debug.Log("Total Bill: " + totalBillAmount.ToString("c2"));
    }

}
