using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class withdrawBtn : CashManaer
{
    public GameObject lackOfCashPannel;
    public void withdraw()
    {
        if (int.Parse(balance.text) - int.Parse(withdrawMoney.text) < 0)
        {
            lackOfCashPannel.SetActive(true);
        }
        if (int.Parse(balance.text) - int.Parse(withdrawMoney.text) >= 0)
        {
            int currentCashTXT = int.Parse(currentCash.text) + int.Parse(withdrawMoney.text);
            currentCash.text = currentCashTXT.ToString();

            int balanceTXT = int.Parse(balance.text) - int.Parse(withdrawMoney.text);
            balance.text = balanceTXT.ToString();
        }
    }


}
