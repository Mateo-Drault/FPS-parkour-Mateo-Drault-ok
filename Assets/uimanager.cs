using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class uimanager : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private void Start()
    {
        txt.text = "$0";
    }
    public void UpdateMoneyText(string moneyAmount)
    {
        txt.text = "$" + moneyAmount;
    }
}
