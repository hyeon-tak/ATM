using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class withdrawBtn : CashManaer
{   
    /// <summary>
    /// ���
    /// </summary>
    //���� �ܰ� ���� �г�
    public GameObject lackOfCashPannel;
    public void withdraw()
    {
        //���� �ܰ� ��� ��� �ݾ׺��� ������
        if (int.Parse(balance.text) - int.Parse(withdrawMoney.text) < 0)
        {
            //���� �ܰ� ���� �г� ��Ƽ��
            lackOfCashPannel.SetActive(true);
        }
        // ���� �ܰ��� ��� ��� �ݾ���  ���� ���
        if (int.Parse(balance.text) - int.Parse(withdrawMoney.text) >= 0)
        {
            //�����ݿ� ��� ��� �ݾ� ���ϱ�
            int currentCashTXT = int.Parse(currentCash.text) + int.Parse(withdrawMoney.text);
            currentCash.text = currentCashTXT.ToString();

            //���� �ܰ� ��� ��� �ݾ� ����
            int balanceTXT = int.Parse(balance.text) - int.Parse(withdrawMoney.text);
            balance.text = balanceTXT.ToString();
        }
    }


}
