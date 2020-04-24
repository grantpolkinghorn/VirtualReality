using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicSetVolume : MonoBehaviour
{
    public AudioMixer GameNoise;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        var volume = PlayerPrefs.GetFloat("MusicVolume");
        GameNoise.SetFloat("M", volume);
    }
}
