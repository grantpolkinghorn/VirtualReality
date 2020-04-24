using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AmbientSetVolume : MonoBehaviour
{
    public AudioMixer GameNoise;
    // Start is called before the first frame update
    void Update()
    {
        var volume = PlayerPrefs.GetFloat("AmbientNoise");
        GameNoise.SetFloat("AV", volume);
    }

}
