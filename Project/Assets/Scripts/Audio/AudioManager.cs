using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is based largely on the tutorial found here: https://youtu.be/1VXeyeLthdQ

public class AudioManager : MonoBehaviour
{
    public static AudioManager audioManager;
    public AudioSource backgroundMusic;
    public AudioSource backgroundMusic2;
    public bool isPlayingBackgroundMusic;
    public AudioClip backgroundTrack;

    /// <summary>
    /// This is a singleton pattern function that ensures there is only one instance of audioManager across the entire project.
    /// </summary>
    private void Awake()
    {
        if (audioManager == null)
        {
            audioManager = this;
        }
    }

    private void Start()
    {
        backgroundMusic = gameObject.AddComponent<AudioSource>();
        backgroundMusic2 = gameObject.AddComponent<AudioSource>();
        isPlayingBackgroundMusic = true;

        ChangeMusic(backgroundTrack);
    }

    /// <summary>
    /// This function changes the music track that is playing to the one passed to the function.
    /// </summary>
    /// <param name="newMusic"></param>
    public void ChangeMusic(AudioClip newMusic)
    { 
        // This should eliminate the need to stop all coroutines, because FadeTrack will only get called if the zone goes from having 0 units to >= 1 units or vice-versa.
        // If for some reason the coroutines start throwing errors, this block of code will need to be deleted and a solve for preventing the track restarting implemented elsewhere.
        if (isPlayingBackgroundMusic)
        {
            // This stops the track from restarting if more units (or other objects) enter the trigger zone.
            if (backgroundMusic.clip.name == newMusic.name)
            {
                return;
            }
        }
        else
        {
            // This stops the track from restarting if more units (or other objects) enter the trigger zone.
            if (backgroundMusic2.clip.name == newMusic.name)
            {
                return;
            }
        }

        FadeTrack(newMusic);
        isPlayingBackgroundMusic = !isPlayingBackgroundMusic;
    }

    /// <summary>
    /// This function will switch the audio track that is playing back to the default background music.
    /// </summary>
    public void ReturnToDefaultBackgroundMusic()
    {
        ChangeMusic(backgroundTrack);
    }

    /// <summary>
    /// This function will fade out the audio track that is playing and will fade in the audio track that is passed into the function.
    /// </summary>
    /// <param name="newMusic"></param>
    /// <returns></returns>
    private IEnumerator FadeTrack(AudioClip newMusic)
    {
        float timeToFade = 1.5f;
        float timeElapsed = 0f;

        if (isPlayingBackgroundMusic)
        {
            backgroundMusic2.clip = newMusic;
            backgroundMusic2.Play();

            // This increases backgroundMusic2 incrementally from 0% to 100% volume in (timeElapsed / timeToFade) amount of steps.
            // It simultaneously decreases backgroundMusic incrementally from 100% to 0% volume in the same amount of steps.
            while (timeElapsed < timeToFade)
            {
                backgroundMusic2.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
                backgroundMusic.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
                yield return null;
            }

            backgroundMusic.Stop();
        }
        else
        {
            backgroundMusic.clip = newMusic;
            backgroundMusic.Play();

            // This increases backgroundMusic incrementally from 0% to 100% volume in (timeElapsed / timeToFade) amount of steps.
            // It simultaneously decreases backgroundMusic2 incrementally from 100% to 0% volume in the same amount of steps.
            while (timeElapsed < timeToFade)
            {
                backgroundMusic.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
                backgroundMusic2.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
                yield return null;
            }

            backgroundMusic2.Stop();
        }
    }
}
