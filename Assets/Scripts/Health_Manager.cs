using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Manager : MonoBehaviour
{
    public int health;
    public uimanager uimanager;
    void Start()
    {
        uimanager.UpdateHealthText(health.ToString());
    }

    void Update()
    {
        
    }
    public void UpdateHealth(int damageAmount)
    {
        if(health + damageAmount <= 0)
        {

            Debug.Log("game over");
            return;
        }
        health += damageAmount;
        uimanager.UpdateHealthText(health.ToString());
    }   
}
