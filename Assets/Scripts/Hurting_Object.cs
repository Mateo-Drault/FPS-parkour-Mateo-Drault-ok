using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurting_Object : MonoBehaviour
{
    public int damagePoints;
    public Health_Manager health_Manager;
    void Start()
    {
        health_Manager = FindObjectOfType <Health_Manager>();
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name== "Player")
        {
            health_Manager.UpdateHealth(-damagePoints);
        }
    }
}
