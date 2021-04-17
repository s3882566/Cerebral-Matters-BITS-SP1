using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenuLogic : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void setMusicVolume(float musicVolume)
    {
        audioMixer.SetFloat("volume", musicVolume);
    }

    public void setSFXVolume(float sFXVolume)
    {
        audioMixer.SetFloat("sfx", sFXVolume);
    }
}
