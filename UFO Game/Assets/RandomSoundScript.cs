using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundScript : MonoBehaviour
{

    public AudioSource source;

    public AudioClip[] audioClips;



    

    // Start is called before the first frame update
    void Start()
    {

        playSound();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void playSound()
    {
        source.clip = audioClips[Random.Range(0, audioClips.Length)];
        source.Play();
    }  
}

    
