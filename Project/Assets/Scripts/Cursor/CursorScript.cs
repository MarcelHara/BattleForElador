using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Resources used from: https://www.youtube.com/watch?v=PTL19bXCsNU
// to learn how mouse pointers etc work.

public class CursorScript : MonoBehaviour
{
    public Texture2D cursor;      // creates a dropdown so we can attach the first cursor png

    public Texture2D cursorClicked;   // creates a dropdown so we can attach the clicked cursor png

    private CursorControls controls;      // Linking the new CursorControls script made with unity to this script calling it controls

    public void OnEnable()     // Enables CursorControls script
    {
        controls.Enable(); 
    }

    public void OnDisabled()   // Disables CursorControls script
    {
        controls.Disable();
    }

    void Start()
    {
        controls.Mouse.Click.started += _ => startedClick();
        controls.Mouse.Click.performed += _ => endedClick();
    }

    private void startedClick()
    {
        ChangeCursor(cursorClicked);
    }

    private void endedClick()
    {
        ChangeCursor(cursor);
    }
    private void Awake() 
    {
        controls = new CursorControls();
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;  // Confined means it stays to the screen and Locked means the cursor is locked in the middle.
    }

    /// <summary>
    /// ChangeCursor is the variable name we use to change the cursor to the clicked png when something hits the hotspot.
    /// The hotspot is the top left of the cursor and is Unity's way of clickDetection
    /// CursorMode.Auto is so the png cursor renders either through hardware if the computer is good enough or software if it is not.
    /// </summary>
    /// <param name="cursorType"></param>
    private void ChangeCursor(Texture2D cursorType)
    {
        Vector2 hotSpot = new Vector2(cursorType.width / 2, cursorType.height / 2);
        Cursor.SetCursor(cursorType, hotSpot, CursorMode.Auto); 
    }





}


