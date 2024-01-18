using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTroop : allTroops
{
    public string troopName;
    public float troopHealth;
    public float troopDamage;
    public bool troopMelee;
    public bool troopRanged;
    public int attackRange;
    private void Awake()
    {
        Init(troopName, troopHealth, troopDamage, troopMelee, troopRanged);
    }

    public override void Init(string troopName, float troopHealth, float troopDamage, bool troopMelee, bool troopRanged)
    {
        base.Init(troopName, troopHealth, troopDamage, troopMelee, troopRanged);
    }

    public override void Update()
    {
        base.Update();
        MeeleRay("Player", attackRange,"Player");
        //MeeleRay("PlayerGolem", attackRange,"Player");
        //MeeleRay("Bubble", attackRange,"Player");
    }
}