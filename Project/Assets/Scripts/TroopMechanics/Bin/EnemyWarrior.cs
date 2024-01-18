//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EnemyWarrior : MonoBehaviour
//{
//    public HealthBar healthBar;

//    allTroops enemytroopWarrior;
//    int collisionRange = 2;     // the range of the melee troops collision

//    void Awake()
//    {
//        /// <summary>
//        /// Name,MaxHP,CurrentHP,is it melee?, is it ranged?
//        /// </summary>
//        /// <returns></returns>
//        enemytroopWarrior = new allTroops("EnemyWarrior", 100, 100, 15, true, false);
//    }
//    void Update()
//    {
//        MeleeRay();   // getting the collisionray method
//        HealthZero();
//    }

//    public void MeleeRay()
//    {
//        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit, collisionRange))
//        {
//            hit.collider.gameObject.GetComponent<WarriorCollision>().GetTroopClass().GetTroopCurrentHealth -= enemytroopWarrior.GetTroopDamage * Time.deltaTime;
//            hit.collider.gameObject.GetComponent<BruteCollision>().GetTroopClass().GetTroopCurrentHealth -= enemytroopWarrior.GetTroopDamage * Time.deltaTime;
//            healthBar.UpdateHealth(enemytroopWarrior.GetTroopCurrentHealth / enemytroopWarrior.GetTroopHealth);
//        }
//        else
//        {
//            Debug.Log("No Enemy detected");
//        }
//    }

//    public allTroops GetTroopClass()
//    {
//        return enemytroopWarrior;
//    }

//    public void HealthZero()
//    {
//        if (enemytroopWarrior.GetTroopCurrentHealth <= 0)
//        {
//            Debug.Log("Destroying object");
//            Destroy(this.gameObject);
//        }
//    }
//}
