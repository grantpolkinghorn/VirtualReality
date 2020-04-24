using UnityEngine;
using System.Collections;

public class CheckSFXVolume : MonoBehaviour {
	public void  Start (){
		// remember volume level from last time
		GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFX");
		Debug.Log(PlayerPrefs.GetFloat("SFX"));
	}

	public void UpdateVolume (){
		GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFX");
	}
}