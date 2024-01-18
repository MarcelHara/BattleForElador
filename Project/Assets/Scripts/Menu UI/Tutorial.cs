using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public bool start = false;
    public bool tutorialHasBeenFinished = false;

    private void Update()
    {
        if (start == true && !tutorialHasBeenFinished)
        {
            StartTutorial();
        }
        else
        {
            CloseTutorial();
        }
    }

    /// <summary>
    /// This stops the game from playing until the player has completed the tutorial.
    /// </summary>
    void StartTutorial()
    {
        Time.timeScale = 0;
    }

    /// <summary>
    /// This starts the game once the player has finished the tutorial.
    /// </summary>
    void CloseTutorial()
    {
        Time.timeScale = 1;
        tutorialHasBeenFinished = true;
        start = false;
    }
}
