using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AItrigger1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<TroopMoveType1>().END();
            other.GetComponent<TroopMoveType2>().END();
            other.GetComponent<TroopMoveType3>().END();
        }
        else if (other.CompareTag("Enemy"))
        {
            other.GetComponent<TroopMoveType1>().END();
            other.GetComponent<TroopMoveType2>().END();
            other.GetComponent<TroopMoveType3>().END();
        }
    }
}
