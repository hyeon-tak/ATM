using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class withdrawBtn : CashManaer
{   
    /// <summary>
    /// 출금
    /// </summary>
    //통장 잔고 부족 패널
    public GameObject lackOfCashPannel;
    public void withdraw()
    {
        //통장 잔고가 출금 희망 금액보다 작으면
        if (int.Parse(balance.text) - int.Parse(withdrawMoney.text) < 0)
        {
            //통장 잔고 부족 패널 액티브
            lackOfCashPannel.SetActive(true);
        }
        // 통장 잔고보다 출금 희망 금액이  작을 경우
        if (int.Parse(balance.text) - int.Parse(withdrawMoney.text) >= 0)
        {
            //소지금에 출금 희망 금액 더하기
            int currentCashTXT = int.Parse(currentCash.text) + int.Parse(withdrawMoney.text);
            currentCash.text = currentCashTXT.ToString();

            //통장 잔고에 출금 희망 금액 빼기
            int balanceTXT = int.Parse(balance.text) - int.Parse(withdrawMoney.text);
            balance.text = balanceTXT.ToString();
        }
    }


}
