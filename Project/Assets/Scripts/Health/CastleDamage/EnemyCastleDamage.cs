using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyCastleDamage : MonoBehaviour
{
    //public GameObject hp;

    public HealthBar healthbar;
    //public int damageNumber;

    public int maxHealth;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WarriorPlayer")
        {
            TakeDamage(50); //gets damage method
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.UpdateHealth((float)currentHealth / (float)maxHealth);
    }
}