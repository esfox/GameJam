using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour 
{
    // Create a separate GameObject in the scene with this script.

    private static AudioManager instance = null;
    public static AudioManager Instance
    {
        get { return instance; }
    }

    void Awake ()
    {
        instance = this;
    }

    //Fill these in the inspector. 
    [SerializeField] private AudioSource[] calmAudio;
    [SerializeField] private AudioSource[] desperationAudio;
    [SerializeField] private AudioSource[] hopeAudio;
    [SerializeField] private AudioSource[] panicAudio;

    //Stores Currently Playing BGM
    private AudioSource currentlyPlaying = null;
 
    public enum AudioType
    {
        Calm,
        Desperation,  
        Hope,
        Panic
    };

    //Takes an AudioType as a parameter
    //Example: PlayAudio(AudioManager.AudioType.Calm);
    public void PlayAudio (AudioType audioType)
    {
        switch (audioType)
        {
            case AudioType.Calm:
                playRandom(calmAudio);
                print("Wow Audio");
                break;
            case AudioType.Desperation:
                playRandom(desperationAudio);
                break;
            case AudioType.Hope:
                playRandom(hopeAudio);
                break;
            case AudioType.Panic:
                playRandom(panicAudio);
                break;
        }
    }

    //Stops Audio
    public void StopAudio ()
    {
        currentlyPlaying.Stop();
    }

    //plays a random track from an audio array
    private void playRandom (AudioSource[] audioArray)
    {
        currentlyPlaying = audioArray[Random.Range(0, audioArray.Length - 1)];
        currentlyPlaying.Play();
    }
}