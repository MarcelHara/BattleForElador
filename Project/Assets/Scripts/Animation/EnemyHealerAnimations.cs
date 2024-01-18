using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealerAnimations : MonoBehaviour
{
    public Animator TroopAnim;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            TroopAnim.SetTrigger("Attack");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            TroopAnim.ResetTrigger("Attack");
        }
    }
}
