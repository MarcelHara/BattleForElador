using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Made with help from https://www.youtube.com/watch?v=pbeB9NsaoPs

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private bool paused;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private GameObject goldUI;

    private void Update()
    {
        // Every time the player hits escape, it either activates or deactivates the pause menu depending on the bool value of "paused".
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }

        if (paused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }

    public void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenu.SetActive(true);
        gameUI.SetActive(false);
        goldUI.SetActive(false);
    }
    
    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenu.SetActive(false);
        gameUI.SetActive(true);
        goldUI.SetActive(true);
        paused = false;
    }
}
