using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript2 : MonoBehaviour
{
    public int precio;
    public MoneyManager moneyManager;
    // Start is called before the first frame update
    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            bool leAlcanza = moneyManager.UpdateMoney(-precio);
            if (leAlcanza)
            {
                Destroy(gameObject);
            }
        }
    }
}
