using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedCastleHealth : MonoBehaviour
{
    public static float maxHealth = 10f;
    public static float currentHealth;
    public static float percentHealth;
    //public Image health;
    public GameObject winScreen;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        percentHealth = currentHealth / maxHealth;
        //health.fillAmount = percentHealth;

        if (currentHealth == 0)
        {
            Debug.Log("You Won");
            winScreen.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // This removes the troop.
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            currentHealth--;
        }
    }
}