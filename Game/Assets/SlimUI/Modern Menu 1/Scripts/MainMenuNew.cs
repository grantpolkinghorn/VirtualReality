using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuNew : MonoBehaviour {

	Animator CameraObject;


	[Header("Panels")]
	[Tooltip("The UI Pop-Up when 'EXIT' is clicked")]
	public GameObject PanelareYouSure;
    public GameObject PanelExit;

	[Header("SFX")]
	[Tooltip("The GameObject holding the Audio Source component for the HOVER SOUND")]
	public GameObject hoverSound;
	[Tooltip("The GameObject holding the Audio Source component for the AUDIO SLIDER")]
	public GameObject sliderSound;
	[Tooltip("The GameObject holding the Audio Source component for the SWOOSH SOUND when switching to the Settings Screen")]
	public GameObject swooshSound;

	void Start(){
		CameraObject = transform.GetComponent<Animator>();
	}

	public void  PlayCampaign (int sceneIndex){
		SceneManager.LoadScene (sceneIndex);
	}



	public void  Position2 (){
		CameraObject.SetFloat("Animate",1);
	}

	public void  Position1 (){
		CameraObject.SetFloat("Animate",0);
	}

	public void PlayHover (){
		hoverSound.GetComponent<AudioSource>().Play();
	}

	public void PlaySFXHover (){
		sliderSound.GetComponent<AudioSource>().Play();
	}

	public void PlaySwoosh (){
		swooshSound.GetComponent<AudioSource>().Play();
	}

	// Are You Sure - Quit Panel Pop Up
	public void  AreYouSure (){
		PanelareYouSure.gameObject.SetActive(true);
        PanelExit.gameObject.SetActive(false);
	}

	public void  No (){
		PanelareYouSure.gameObject.SetActive(false);
        PanelExit.gameObject.SetActive(true);
    }

	public void  Yes (){
		Application.Quit();
	}
}