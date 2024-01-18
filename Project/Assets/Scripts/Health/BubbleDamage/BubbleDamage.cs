using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleDamage : MonoBehaviour
{

    public GameObject[] bubble;
    public GameObject[] pGolem;
    public GameObject[] eGolem;
    private GolemSpawn golemSpawn;
    public LastHitInfo lastHit;

    void Start()
    {
        golemSpawn = GameObject.Find("GameManager").GetComponent<GolemSpawn>();      // finds GameManager object in heirarchy and assigns script component GolemSpawn to golemSpawn
        
    }

    private void Update()
    {
        bubble = GameObject.FindGameObjectsWithTag("Bubble");
        pGolem = GameObject.FindGameObjectsWithTag("PlayerGolem");
        eGolem = GameObject.FindGameObjectsWithTag("EnemyGolem");

        if(pGolem.Length <= 0 && eGolem.Length <= 0)
        {
            SpawnGolem();
        }
    }

    public void SpawnGolem()
    {
        if (bubble.Length <= 0 && lastHit.enemy == true)
        {
            golemSpawn.spawnEnemyGolem(); //Calls Golem Spawn function from GolemSpawn script
        }
        if (bubble.Length <= 0 && lastHit.player == true)
        {
            golemSpawn.spawnPlayerGolem();
        }
    }

}
