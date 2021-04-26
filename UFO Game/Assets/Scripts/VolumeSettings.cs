using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider musicSlider, sFXSlider;

    private void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVol", 0.75f);
        sFXSlider.value = PlayerPrefs.GetFloat("SFXVol", 0.75f);
    }

    public void SetMusicVolume(float musicVolume)
    {
        Debug.Log(musicVolume);
        // Mathf.Log10()*20 converts logarithmic to linear
        audioMixer.SetFloat("volume", Mathf.Log10(musicVolume) * 20);
        PlayerPrefs.SetFloat("MusicVol", musicVolume);
    }

    public void SetSFXVolume(float sFXVolume)
    {
        Debug.Log(sFXVolume);
        audioMixer.SetFloat("sfx", Mathf.Log10(sFXVolume) * 20);
        PlayerPrefs.SetFloat("SFXVol", sFXVolume);
    }

}
