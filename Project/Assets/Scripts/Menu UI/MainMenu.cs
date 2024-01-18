using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// This is a link to a YouTube video that I used as a basis for the main menu
// https://youtu.be/zc8ac_qUXQY

public class MainMenu : MonoBehaviour
{
    public string levelToLoad;
    [SerializeField] private GameObject noSaveFileFoundDialog = null;

    public void NewGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void CheckForSaveFile()
    {
        // This checks to see if there is a file called "SaveFile".
        if (PlayerPrefs.HasKey("SaveFile"))
        {
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            noSaveFileFoundDialog.SetActive(true);
        }
    }

    public void ExitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();     
    }
}
