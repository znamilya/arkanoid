using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : SingletonBehavior<MusicPlayer>
{

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Toggle()
    {
        AudioSource a = GetComponent<AudioSource>();

        a.mute = !a.mute;
    }
}
