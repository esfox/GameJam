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

    //Fill these in the inspector: 

    //BGM
    [SerializeField] private AudioSource[] calmAudio;
    [SerializeField] private AudioSource[] desperationAudio;
    [SerializeField] private AudioSource[] hopeAudio;
    [SerializeField] private AudioSource[] panicAudio;

    [SerializeField] private AudioSource menuAudio;
    [SerializeField] private AudioSource gloomyAudio;
    [SerializeField] private AudioSource mazeAudio;
    [SerializeField] private AudioSource ruinsAudio;
    [SerializeField] private AudioSource wetLandsAudio;

    //SFX
    [SerializeField] private AudioSource[] metalAudio;

    [SerializeField] private AudioSource acquireItemAudio;
    [SerializeField] private AudioSource dayShiftAudio;
    [SerializeField] private AudioSource nightShiftAudio;
    [SerializeField] private AudioSource footstepsAudio;
    [SerializeField] private AudioSource stormAudio;
    [SerializeField] private AudioSource attackAudio;

    //Stores Currently Playing BGM
    private AudioSource currentlyPlaying = null;
 
    public enum AudioType
    {
        Menu,
        Gloomy,
        Maze,
        Ruins,
        Wetlands,
        Calm,
        Desperation,  
        Hope,
        Panic,
    };

    public enum SFX_Type
    {
        Acquire_Item,
        Day_Shift,
        Night_Shift,
        Footsteps,
        Metal,
        Storm,
        Attack
    }

    //Takes an AudioType as a parameter
    //Example: PlayBGM(AudioManager.AudioType.Calm);
    public void PlayBGM (AudioType audioType)
    {
        switch (audioType)
        {
            case AudioType.Menu:
                playSpecific(menuAudio);
                break;
            case AudioType.Gloomy:
                playSpecific(gloomyAudio);
                break;
            case AudioType.Maze:
                playSpecific(mazeAudio);
                break;
            case AudioType.Ruins:
                playSpecific(ruinsAudio);
                break;
            case AudioType.Wetlands:
                playSpecific(wetLandsAudio);
                break;
            case AudioType.Calm:
                playRandom(calmAudio);
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

    //Parameters:
    //AudioManager.SFX_Type.sfxType,  boolean if play or stop
    public void HandleSFX (SFX_Type sfxType, bool play)
    {
        AudioSource sfx = null;
        switch (sfxType)
        {
            case SFX_Type.Acquire_Item:
                sfx = acquireItemAudio;
                break;
            case SFX_Type.Day_Shift:
                sfx = dayShiftAudio;
                break;
            case SFX_Type.Night_Shift:
                sfx = nightShiftAudio;
                break;
            case SFX_Type.Footsteps:
                sfx = footstepsAudio;
                break;
            case SFX_Type.Metal:
                sfx = metalAudio[Random.Range(0, metalAudio.Length - 1)];
                break;
            case SFX_Type.Storm:
                sfx = stormAudio;
                break;
            case SFX_Type.Attack:
                sfx = attackAudio;
                break;
        }

        if (play)
            sfx.Play();
        else
            sfx.Stop();
    }

    //Stops Audio
    public void StopAudio ()
    {
        currentlyPlaying.Stop();
    }

    private void playSpecific (AudioSource audio)
    {
        audio.Play();
        currentlyPlaying = audio;
    }

    //plays a random track from an audio array
    private void playRandom (AudioSource[] audioArray)
    {
        currentlyPlaying = audioArray[Random.Range(0, audioArray.Length - 1)];
        currentlyPlaying.Play();
    }
}