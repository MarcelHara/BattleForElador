using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneClick : MonoBehaviour
{
    // Variables
    public GoldManager goldmanager;
    public GameObject Warrior;
    public GameObject Archer;
    public GameObject Assassin;
    public GameObject Healer;
    public GameObject Brute;
    public GameObject Mage;
    public Transform troopSpawn;

    /// <summary>
    /// Button is for the click so on click it will activate the TroopSpawner method
    /// </summary>
    public void Button()
    {
        TroopSpawner();
    }
    
    /// <summary>
    /// Checks if any of the statements is true when a player clicks on the UI for the troops and checks if they have any gold
    /// also removes gold on purchase and it spawns the troop with the position and rotation correct
    /// </summary>
    private void TroopSpawner()
    {
        //Warrior
        if(Warrior && goldmanager.GoldValue >= 50)   // change the numbers for both to change the gold cost
        {
            Instantiate(Warrior, troopSpawn.transform.position, troopSpawn.transform.rotation);
            goldmanager.GoldValue -= 50; 
        }
        //Archer
        if (Archer && goldmanager.GoldValue >= 75)
        {
            Instantiate(Archer, troopSpawn.transform.position, troopSpawn.transform.rotation);
            goldmanager.GoldValue -= 75; 
        }
        //Assassin
        if (Assassin && goldmanager.GoldValue >= 75)
        {
            Instantiate(Assassin, troopSpawn.transform.position, troopSpawn.transform.rotation);
            goldmanager.GoldValue -= 75; 
        }
        //Healer
        if (Healer && goldmanager.GoldValue >= 100)
        {
            Instantiate(Healer, troopSpawn.transform.position, troopSpawn.transform.rotation);
            goldmanager.GoldValue -= 100; 
        }
        //Brute
        if (Brute && goldmanager.GoldValue >= 150)
        {
            Instantiate(Brute, troopSpawn.transform.position, troopSpawn.transform.rotation);
            goldmanager.GoldValue -= 150; 
        }
        //Mage
        if (Mage && goldmanager.GoldValue >= 200)  
        {
            Instantiate(Mage, troopSpawn.transform.position, troopSpawn.transform.rotation);
            goldmanager.GoldValue -= 200; 
        }
    }
}
