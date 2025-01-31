﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioManager
{
    #region

    static Dictionary<AudioClipNames, AudioClip> sound = new Dictionary<AudioClipNames, AudioClip>();
    public static AudioSource audioSource;
    static bool initialized = false;

    #endregion

    #region Properties

    public static bool Initialized 
    { get { return initialized; } }

    #endregion

    #region Methods

    public static void Initialize(AudioSource source)
    {
        initialized = true;
        audioSource = source;
        sound.Add(AudioClipNames.Merge, Resources.Load(@"Audio\Merge") as AudioClip);
        sound.Add(AudioClipNames.Drop, Resources.Load(@"Audio\Drop") as AudioClip);
        sound.Add(AudioClipNames.Button, Resources.Load(@"Audio\button") as AudioClip);
    }

    public static void Play(AudioClipNames name)
    {
        if(sound.ContainsKey(name))
        {
            audioSource.PlayOneShot(sound[name]);
        }
    }

    #endregion
}
