using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealingMech : MonoBehaviour
{
    // variable stats
    public float healingPerSecond;

    // mechanics
    private void OnTriggerStay(Collider coll) // triggerStay means it constantly ticks instead of just activating once like Enter would
    {
        if (coll.gameObject.tag == "Enemy")   
        {
            if(coll.gameObject.GetComponent<EnemyTroop>()._troopCurrentHealth < coll.gameObject.GetComponent<EnemyTroop>()._troopHealth)
            {
                coll.gameObject.GetComponent<EnemyTroop>()._troopCurrentHealth += healingPerSecond * Time.deltaTime;
            }
        }
    }

}
