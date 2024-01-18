using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastHitInfo : MonoBehaviour
{

    public LastHitDetection lhd;
    public bool player, enemy;
    // Start is called before the first frame update
    void Start()
    {
        player = false;
        enemy = false;
    }

    // Update is called once per frame
    void Update()
    {
        lhd = GameObject.Find("Bubble(Clone)").GetComponent<LastHitDetection>();
        player = lhd.playerLastHit;
        enemy = lhd.enemyLastHit;
    }
}
