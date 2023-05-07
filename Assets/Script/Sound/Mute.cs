using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Mute : MonoBehaviour
{
    [SerializeField] private AudioMixer aMix;
    bool isMutedMusic =false;
    bool isMutedVFX = false;
    public void muteMusic()
    {
        if (isMutedMusic)
        {
            aMix.SetFloat("Music", 0);
            isMutedMusic = !isMutedMusic;
            print(isMutedMusic);
        }
        else if(!isMutedMusic)
        {
            aMix.SetFloat("Music", -88);
            isMutedMusic = !isMutedMusic;
            print(isMutedMusic);
        }
    }
    public void muteVFX()
    {
        if (isMutedVFX)
        {
            aMix.SetFloat("SoundEffects", 0);
            isMutedVFX = !isMutedVFX;
            print(isMutedVFX);
        }
        else if (!isMutedVFX)
        {
            aMix.SetFloat("SoundEffects", -88);
            isMutedVFX = !isMutedVFX;
            print(isMutedVFX);
        }
    }
}