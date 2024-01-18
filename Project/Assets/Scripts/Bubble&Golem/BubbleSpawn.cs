using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawn : MonoBehaviour
{

    public GameObject bubble;

    public BubbleDamage bubbleHealth;
    public GolemSpawn golemSpawn;

    public Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(bubble, spawnPos, Quaternion.identity); //Spawns bubble at start of game
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
