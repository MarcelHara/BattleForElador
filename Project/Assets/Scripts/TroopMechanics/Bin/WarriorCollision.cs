//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//public class WarriorCollision : MonoBehaviour
//{
//    public HealthBar healthBar;
//    public static WarriorCollision instance;  // this is the only instance of this player

//    allTroops troopWarrior;
//    //allTroops troopBrute;
//    int collisionRange = 2;     // the range of the melee troops collision

//    void Awake()
//    {
//        instance = this;  // this means there is only one instance of this object aka PLAYER
//        /// <summary>
//        /// Name,MaxHP,CurrentHP,is it melee?, is it ranged?
//        /// </summary>
//        /// <returns></returns>
//        this.troopWarrior = new allTroops("Warrior", 100, 100, 15, true, false);
//        //this.troopBrute = new allTroops("Brute", 250, 250, 40, true, false);
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
//            hit.collider.gameObject.GetComponent<EnemyWarrior>().GetTroopClass().GetTroopCurrentHealth -= troopWarrior.GetTroopDamage * Time.deltaTime;
//            hit.collider.gameObject.GetComponent<EnemyBrute>().GetTroopClass().GetTroopCurrentHealth -= troopWarrior.GetTroopDamage * Time.deltaTime;
//            healthBar.UpdateHealth(troopWarrior.GetTroopCurrentHealth / troopWarrior.GetTroopHealth);
//        }
//        else
//        {
//            Debug.Log("No Enemy detected");
//        }
//    }

//    public allTroops GetTroopClass()
//    {
//        return troopWarrior;
//    }
//    public void HealthZero()
//    {
//        if (troopWarrior.GetTroopCurrentHealth <= 0)
//        {
//            Debug.Log("Destroying object");
//            Destroy(this.gameObject);
//        }
//    }
//}
