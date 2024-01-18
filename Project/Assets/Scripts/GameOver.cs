using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RedCastleHealth.currentHealth == 0)
        {
            Time.timeScale = 0f;
            Debug.Log("Blue Wins");
        }
        if (BlueCastleHealth.currentHealth == 0)
        {
            Time.timeScale = 0f;
            Debug.Log("Red Wins");
        }
    }
}
