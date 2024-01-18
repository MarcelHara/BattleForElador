using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Characater : MonoBehaviour
{
    [HideInInspector] public float maxHealth;
    public HealthBar healthbar;

    //public int damageNumber;

    public float currentHealth;


    void Start()
    {
        currentHealth = maxHealth;
    }

    /*public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.UpdateHealth((float)currentHealth / (float)maxHealth);
    }*/

}
