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
        int withdrawMoneyINT;
        bool withdrawMoneyBool = int.TryParse(withdrawMoney.text, out withdrawMoneyINT);
        if(withdrawMoneyBool)
        {
            //���� �ܰ� ��� ��� �ݾ׺��� ������
            if (int.Parse(balance.text) - withdrawMoneyINT < 0)
            {
                //���� �ܰ� ���� �г� ��Ƽ��
                lackOfCashPannel.SetActive(true);
            }
            // ���� �ܰ��� ��� ��� �ݾ���  ���� ���
            if (int.Parse(balance.text) - withdrawMoneyINT >= 0)
            {
                //�����ݿ� ��� ��� �ݾ� ���ϱ�
                int currentCashTXT = int.Parse(currentCash.text) + withdrawMoneyINT;
                currentCash.text = currentCashTXT.ToString();

                //���� �ܰ� ��� ��� �ݾ� ����
                int balanceTXT = int.Parse(balance.text) - withdrawMoneyINT;
                balance.text = balanceTXT.ToString();
            }
        }
        else
        {
            withdrawMoney.text = "";
        }
        
    }


}
