using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrnecyUpdate : MonoBehaviour
{

    public Text bal;
    public float goldPS;
    public float goldAmmount;
    public float timer;
    public float oneSecond = 1;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if(timer >= oneSecond)
        {
            goldAmmount += goldPS;
            timer = 0;
        }

        bal.text = "GOLD: " + goldAmmount;
    }
}
