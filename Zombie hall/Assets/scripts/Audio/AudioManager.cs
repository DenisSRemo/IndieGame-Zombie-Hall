using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    void Awake()
    {
        //it will create am audio source for every sound effect saved in the array
        foreach(Sound s in sounds)
        {
            s.source= gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    //when called, it would play the specific sound effect based on the name
    public void Play(string name)
    {
       Sound s= Array.Find(sounds, sound => sound.name == name);
        if(s==null)
        {
            return;
        }

        s.source.Play();
    }







    
}
