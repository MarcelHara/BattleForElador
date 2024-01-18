using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealingMech : MonoBehaviour
{
    // variable stats
    public float healingPerSecond;

    // mechanics
    private void OnTriggerStay(Collider coll) // triggerStay means it constantly ticks instead of just activating once like Enter would
    {
        if (coll.gameObject.tag == "Player")
        {
            if (coll.gameObject.GetComponent<AllyTroop>()._troopCurrentHealth < coll.gameObject.GetComponent<AllyTroop>()._troopHealth) // IT DOES DETECT THIS
            {
                coll.gameObject.GetComponent<AllyTroop>()._troopCurrentHealth += healingPerSecond * Time.deltaTime;
            }
        }
    }

}
