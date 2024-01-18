using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastHitDetection : MonoBehaviour
{

    public bool enemyLastHit = false;
    public bool playerLastHit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "Enemy")
        {
            enemyLastHit = true;
            playerLastHit = false;
        }
        if(collision.collider.tag == "Player")
        {
            playerLastHit = true;
            enemyLastHit = false;
        }
    }
}
