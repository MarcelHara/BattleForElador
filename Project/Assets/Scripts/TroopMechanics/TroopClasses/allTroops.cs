using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class allTroops : MonoBehaviour  // abstract means that you can only inherit it
{
    public string _troopName { get; set; }
    public float _troopHealth { get; set; }
    public float _troopCurrentHealth { get; set; }
    public float _troopDamage { get; set; }
    public bool _troopMelee { get; set; }
    public bool _troopRanged { get; set; }

    public virtual void Init(string troopName, float troopHealth, float troopDamage, bool troopMelee, bool troopRanged)  // virtual means it can be override by other scripts
    {
        _troopName = troopName;
        _troopHealth = troopHealth;
        _troopCurrentHealth = troopHealth;
        _troopDamage = troopDamage;
        _troopMelee = troopMelee;
        _troopRanged = troopRanged;
    }

    public virtual void Update()
    {
        GetComponentInChildren<HealthBar>().UpdateHealth(_troopCurrentHealth / _troopHealth);
        HealthZero();
    }
    public virtual void MeeleRay(string inflictDamageTo, int collisionRange,string layermask)
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit, collisionRange, LayerMask.NameToLayer(layermask)))
        {
            if (hit.collider.gameObject.transform.root.tag == inflictDamageTo)
            {
                _troopCurrentHealth -= hit.collider.gameObject.transform.root.GetComponent<allTroops>()._troopDamage * Time.deltaTime;
            }
        }
        if (Physics.Raycast(transform.position, Quaternion.Euler(0, 45, 0) * transform.forward, out RaycastHit hit2, collisionRange, LayerMask.NameToLayer(layermask)))
        {
            if (hit2.collider.gameObject.transform.root.tag == inflictDamageTo)
            {
                _troopCurrentHealth -= hit2.collider.gameObject.transform.root.GetComponent<allTroops>()._troopDamage * Time.deltaTime;
            }
        }
        if (Physics.Raycast(transform.position, Quaternion.Euler(0, -45, 0) * transform.forward, out RaycastHit hit3, collisionRange, LayerMask.NameToLayer(layermask)))
        {
            if (hit3.collider.gameObject.transform.root.tag == inflictDamageTo)
            {
                _troopCurrentHealth -= hit3.collider.gameObject.transform.root.GetComponent<allTroops>()._troopDamage * Time.deltaTime;
            }
        }
        if (Physics.Raycast(transform.position, Quaternion.Euler(0, 20, 0) * transform.forward, out RaycastHit hit4, collisionRange, LayerMask.NameToLayer(layermask)))
        {
            if (hit4.collider.gameObject.transform.root.tag == inflictDamageTo)
            {
                _troopCurrentHealth -= hit4.collider.gameObject.transform.root.GetComponent<allTroops>()._troopDamage * Time.deltaTime;
            }
        }
        if (Physics.Raycast(transform.position, Quaternion.Euler(0, -20, 0) * transform.forward, out RaycastHit hit5, collisionRange, LayerMask.NameToLayer(layermask)))
        {
            if (hit5.collider.gameObject.transform.root.tag == inflictDamageTo)
            {
                _troopCurrentHealth -= hit5.collider.gameObject.transform.root.GetComponent<allTroops>()._troopDamage * Time.deltaTime;
            }
        }
        Debug.DrawRay(transform.position, Quaternion.Euler(0, 45, 0) * transform.forward, Color.red);
        Debug.DrawRay(transform.position, Quaternion.Euler(0, -45, 0) * transform.forward, Color.red);
        Debug.DrawRay(transform.position, Quaternion.Euler(0, 20, 0) * transform.forward, Color.red);
        Debug.DrawRay(transform.position, Quaternion.Euler(0, -20, 0) * transform.forward, Color.red);
    }

    public void HealthZero()
    {
        if (_troopCurrentHealth <= 0)
        {
            Debug.Log("Destroying object");
            Destroy(gameObject);
        }
    }
}