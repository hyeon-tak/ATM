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
        //�����ݺ��� �Ա� ����ݾ��� Ŭ ��
        if (int.Parse(currentCash.text) - int.Parse(depositMoney.text) < 0)
        {
            //�ܾ��� �����մϴ� �г� ��Ƽ��
            InsufficientBalance.SetActive(true);
        }
        //�������� �Ա� ��� �ݾ׺��� ���� �� 
        else if (int.Parse(currentCash.text) - int.Parse(depositMoney.text) >= 0)
        {
            //�����ݿ��� �Ա� ��� �ݾ� ����
            int currentCashTXT = int.Parse(currentCash.text) - int.Parse(depositMoney.text);
            currentCash.text = currentCashTXT.ToString();

            //���� �ܰ� �Ա� ��� �ݾ� ���ϱ�
            int balanceTXT = int.Parse(balance.text) + int.Parse(depositMoney.text);
            balance.text = balanceTXT.ToString();
        }
    }
}
