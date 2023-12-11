using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CashManaer : MonoBehaviour
{
    public Text currentCash;
    public Text balance;
    public TMP_InputField depositMoney;
    public TMP_InputField withdrawMoney;

    private void Start()
    {
        currentCash.text = "100000";
        balance.text = "50000";
    }

    

    
}
