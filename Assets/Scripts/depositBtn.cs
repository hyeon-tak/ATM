using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class depositBtn : CashManaer
{

    public GameObject InsufficientBalance;

    public void deposit()
    {
        if (int.Parse(currentCash.text) - int.Parse(depositMoney.text) < 0)
        {
            InsufficientBalance.SetActive(true);
        }
        else if (int.Parse(currentCash.text) - int.Parse(depositMoney.text) >= 0)
        {
            int currentCashTXT = int.Parse(currentCash.text) - int.Parse(depositMoney.text);
            currentCash.text = currentCashTXT.ToString();

            int balanceTXT = int.Parse(balance.text) + int.Parse(depositMoney.text);
            balance.text = balanceTXT.ToString();
        }
    }
}
