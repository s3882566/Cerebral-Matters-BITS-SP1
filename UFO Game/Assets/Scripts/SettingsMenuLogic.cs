using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SettingsMenuLogic : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetMusicVolume(float musicVolume)
    {
        Debug.Log(musicVolume);
        audioMixer.SetFloat("volume", musicVolume);
    }

    public void SetSFXVolume(float sFXVolume)
    {
        Debug.Log(sFXVolume);
        audioMixer.SetFloat("sfx", sFXVolume);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }



}
