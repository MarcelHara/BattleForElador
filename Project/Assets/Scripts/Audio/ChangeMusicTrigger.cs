using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is based largely on the tutorial found here: https://youtu.be/1VXeyeLthdQ

/// <summary>Class <c>ChangeMusicTrigger</c>
/// In order to use this script, add a collider box to an object, add this script to that object, and then drag in the desired audio track. 
/// Make sure to add the "Unit" tag on all unit objects. 
/// </summary>
public class ChangeMusicTrigger : MonoBehaviour
{
    public AudioClip newTrack;

    /// <summary>
    /// This is a trigger function that will cause the background music track to change when an object (i.e. a unit) enters a trigger area.
    /// This will only work with 3D objects.
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        // This needs to be updated with an if statement to check and see if it's an enemy unit before reverting to default background music.
        if (other.tag == "Unit")
        {
            AudioManager.audioManager.ChangeMusic(newTrack);
        }
    }

    /// <summary>
    /// This is a trigger function that will cause the background music track to change when an object (i.e. a unit) exits a trigger area.
    /// This will only work with 3D objects.
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        // This needs to be updated with an if statement to check and see if there are any enemy units left in the area before reverting to default background music.
        if(other.tag == "Unit")
        {
            AudioManager.audioManager.ReturnToDefaultBackgroundMusic();
        }
    }
}
