using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public uimanager uimanager;
    public float money;
    private void Start()
    {
        uimanager.UpdateMoneyText(money.ToString());
    }
    public bool UpdateMoney(float amount)
    {
           if (money + amount < 0)
        {
            Debug.Log("no es posible realizar la accion");
        }
            money += amount;
        uimanager.UpdateMoneyText(money.ToString());
            return true;
    }
}
