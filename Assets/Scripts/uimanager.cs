using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class uimanager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtHealth;

    private void Start()
    {
        txtMoney.text = "$0";
    }
    public void UpdateMoneyText(string moneyAmount)
    {
        txtMoney.text = "$" + moneyAmount;
    }
    public void UpdateHealthText(string HealthPoints)
    {
        txtHealth.text = "HP" + HealthPoints;
    }
}
