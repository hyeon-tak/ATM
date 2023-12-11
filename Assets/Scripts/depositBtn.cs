using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class depositBtn : CashManaer
{
    /// <summary>
    /// 입금
    /// </summary>
    
    //입금 가능 금액(소지금) 부족 패널
    public GameObject InsufficientBalance;

    public void deposit()
    {
        int depositMoneyINT;
        bool depositMoneyBool = int.TryParse(depositMoney.text, out depositMoneyINT);
        if (depositMoneyBool)
        {
            //소지금보다 입금 희망금액이 클 때
            if (int.Parse(currentCash.text) - depositMoneyINT < 0)
            {
                //잔액이 부족합니다 패널 액티브
                InsufficientBalance.SetActive(true);
            }
            //소지금이 입금 희망 금액보다 많을 때 
            else if (int.Parse(currentCash.text) - depositMoneyINT >= 0)
            {
                //소지금에서 입금 희망 금액 빼기
                int currentCashTXT = int.Parse(currentCash.text) - depositMoneyINT;
                currentCash.text = currentCashTXT.ToString();

                //통장 잔고에 입금 희망 금액 더하기
                int balanceTXT = int.Parse(balance.text) + depositMoneyINT;
                balance.text = balanceTXT.ToString();
            }
        }
        else
        {
            depositMoney.text = "";
        }
        
    }
}
