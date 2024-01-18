using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private bool tutorialPlayed = false;
    public GameObject tutorialPanel;

    // Start is called before the first frame update
    void Start()
    {
        if (tutorialPlayed)
        {
            tutorialPanel.GetComponent<RectTransform>();
            tutorialPanel.SetActive(false);
        }
    }

    private void ExitTutorial()
    {

    }
}
