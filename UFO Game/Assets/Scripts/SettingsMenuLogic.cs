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
        // Mathf.Log10()*20 converts logarithmic to linear
        audioMixer.SetFloat("volume", Mathf.Log10(musicVolume)*20);
    }

    public void SetSFXVolume(float sFXVolume)
    {
        Debug.Log(sFXVolume);
        audioMixer.SetFloat("sfx", Mathf.Log10(sFXVolume)*20);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }



}
