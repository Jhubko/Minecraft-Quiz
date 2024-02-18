using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource soundPlayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySoundEfect()
    {
        soundPlayer.Play();
    }

    public void StopSoundEfect()
    {
        soundPlayer.Stop();
    }
}
