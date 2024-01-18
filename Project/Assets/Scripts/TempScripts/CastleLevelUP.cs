using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleLevelUP : MonoBehaviour
{
    public CurrnecyUpdate currencyUpdate;
    public int castleLvl;
    public float goldNeeded;
    public Text castlesLevel;

    // Start is called before the first frame update
    void Start()
    {
        castleLvl = 1;
        goldNeeded = 16;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelUp()
    {
        Debug.Log("Button has been clicked");
        if (currencyUpdate.goldAmmount >= goldNeeded && castleLvl <= 4)
        {
            Debug.Log("Levelled Up");
            castleLvl += 1;
            castlesLevel.text = "Castle Level " + castleLvl;
            currencyUpdate.goldAmmount = currencyUpdate.goldAmmount - goldNeeded;
            currencyUpdate.goldPS = currencyUpdate.goldPS + 2;
            goldNeeded = goldNeeded * 1.5f;
        }
        else if(currencyUpdate.goldAmmount < goldNeeded || castleLvl > 4)
        {
            Debug.Log("Not enough gold or reached max level");
            Debug.Log("" + goldNeeded);
        }
    }
}
