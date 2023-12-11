using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class depositBtn : CashManaer
{
    /// <summary>
    /// �Ա�
    /// </summary>
    
    //�Ա� ���� �ݾ�(������) ���� �г�
    public GameObject InsufficientBalance;

    public void deposit()
    {
        int depositMoneyINT;
        bool depositMoneyBool = int.TryParse(depositMoney.text, out depositMoneyINT);
        if (depositMoneyBool)
        {
            //�����ݺ��� �Ա� ����ݾ��� Ŭ ��
            if (int.Parse(currentCash.text) - depositMoneyINT < 0)
            {
                //�ܾ��� �����մϴ� �г� ��Ƽ��
                InsufficientBalance.SetActive(true);
            }
            //�������� �Ա� ��� �ݾ׺��� ���� �� 
            else if (int.Parse(currentCash.text) - depositMoneyINT >= 0)
            {
                //�����ݿ��� �Ա� ��� �ݾ� ����
                int currentCashTXT = int.Parse(currentCash.text) - depositMoneyINT;
                currentCash.text = currentCashTXT.ToString();

                //���� �ܰ� �Ա� ��� �ݾ� ���ϱ�
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
