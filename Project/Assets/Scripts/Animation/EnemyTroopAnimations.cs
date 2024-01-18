using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTroopAnimations : MonoBehaviour
{
    public Animator TroopAnim;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TroopAnim.SetTrigger("Attack");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TroopAnim.ResetTrigger("Attack");
        }
    }
}
