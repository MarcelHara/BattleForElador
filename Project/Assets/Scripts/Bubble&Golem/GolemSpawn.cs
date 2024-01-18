using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemSpawn : MonoBehaviour
{
    public GameObject enemyGolem;
    public GameObject playerGolem;

    public Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = new Vector3(-3.36f, 1f, -5.17f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnEnemyGolem()
    {
        Instantiate(enemyGolem, spawnPos, Quaternion.identity);
    }
    public void spawnPlayerGolem()
    {
        Instantiate(playerGolem, spawnPos, Quaternion.identity);
    }
}
