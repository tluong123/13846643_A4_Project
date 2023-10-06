using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroToNormalStateAudio : MonoBehaviour
{
    public AudioSource IntroMusic;
    public AudioSource NormalState;
    
    private bool isPlayingAudio1 = false;
    // Start is called before the first frame update
    void Start()
    {
    
    
        // Start playing the first audio source
        IntroMusic.Play();
        isPlayingAudio1 = true;
        
    }
    // Update is called once per frame
    void Update()
    {
        // Check if the first audio source has finished playing
        if (isPlayingAudio1 && !IntroMusic.isPlaying)
        {
            // Start playing the second audio source and set it to loop
            NormalState.Play();
            NormalState.loop = true;
            isPlayingAudio1 = false;
        }
    }
}
