//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EnemyBrute : MonoBehaviour
//{
//    public HealthBar healthBar;

//    allTroops enemytroopBrute;
//    int collisionRange = 2;     // the range of the melee troops collision

//    void Awake()
//    {
//        /// <summary>
//        /// Name,MaxHP,CurrentHP,is it melee?, is it ranged?
//        /// </summary>
//        /// <returns></returns>
//        enemytroopBrute = new allTroops("Brute", 250, 250, 40, true, false);
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
//            hit.collider.gameObject.GetComponent<BruteCollision>().GetTroopClass().GetTroopCurrentHealth -= enemytroopBrute.GetTroopDamage * Time.deltaTime;
//            hit.collider.gameObject.GetComponent<WarriorCollision>().GetTroopClass().GetTroopCurrentHealth -= enemytroopBrute.GetTroopDamage * Time.deltaTime;
//            healthBar.UpdateHealth(enemytroopBrute.GetTroopCurrentHealth / enemytroopBrute.GetTroopHealth);
//        }
//        else
//        {
//            Debug.Log("No Enemy detected");
//        }
//    }

//    public allTroops GetTroopClass()
//    {
//        return enemytroopBrute;
//    }

//    public void HealthZero()
//    {
//        if (enemytroopBrute.GetTroopCurrentHealth <= 0)
//        {
//            Debug.Log("Destroying object");
//            Destroy(this.gameObject);
//        }
//    }
//}
