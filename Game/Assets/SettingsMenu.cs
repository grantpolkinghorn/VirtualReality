using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SettingsMenu : MonoBehaviour
{
    public AudioMixer GameNoise;
 
    public void AmbientSetVolume(float volume)
    {
//        volume = PlayerPrefs.GetFloat("AmbientNoise");
        GameNoise.SetFloat("AV", volume);
    }
    public void SFXSetVolume(float volume)
    {
//        volume = PlayerPrefs.GetFloat("SFX");
        GameNoise.SetFloat("S", volume);
    }
    public void MusicSetVolume(float volume)
    {
//        volume = PlayerPrefs.GetFloat("MusicVolume");
        GameNoise.SetFloat("M", volume);
    }
}
