using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsMenuNew : MonoBehaviour {

	// toggle buttons

	public GameObject tooltipontext;
	public GameObject tooltipontextLINE;
	public GameObject tooltipofftext;
	public GameObject tooltipofftextLINE;


	// sliders
	public GameObject musicSlider;
	public GameObject brightnessSlider;
	public GameObject ambientNoiseSlider;
	public GameObject sfxSlider;

	private float sliderValue = 0.0f;
	private float brightnessSliderValue = 0.0f;
	private float ambientNoiseSliderValue = 0.0f;
	private float sfxSliderValue = 0.0f;

    public void Start()
    {
        // check difficulty
        if (PlayerPrefs.GetInt("ToolTipsOn") == 1)
        {
            tooltipontextLINE.gameObject.SetActive(true);
            tooltipofftextLINE.gameObject.SetActive(false);
        }
        else
        {
            tooltipofftextLINE.gameObject.SetActive(true);
            tooltipontextLINE.gameObject.SetActive(false);
        }

        // check slider values
        musicSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("MusicVolume");
        brightnessSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("XSensitivity");
        ambientNoiseSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("YSensitivity");
        sfxSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("MouseSmoothing");

        /* check tool tip value
		if(PlayerPrefs.GetInt("ToolTips")==0){
			tooltipstext.GetComponent<Text>().text = "off";
		}
		else{
			tooltipstext.GetComponent<Text>().text = "on";
		*/
    }

	public void  Update (){
		sliderValue = musicSlider.GetComponent<Slider>().value;
        brightnessSliderValue = brightnessSlider.GetComponent<Slider>().value;
        ambientNoiseSliderValue = sfxSlider.GetComponent<Slider>().value;
        sfxSliderValue = ambientNoiseSlider.GetComponent<Slider>().value;
	}

	public void MusicSlider (){
		PlayerPrefs.SetFloat("MusicVolume", sliderValue);
	}

	public void  BrightnessSlider (){
		PlayerPrefs.SetFloat("Brightness", brightnessSliderValue);
	}

	public void  AmbientNoiseSlider (){
		PlayerPrefs.SetFloat("AmbientNoise", ambientNoiseSliderValue);
	}

	public void  SFXSlider (){
		PlayerPrefs.SetFloat("SFX", sfxSliderValue);
	}

	/* show tool tips like: 'How to Play' control pop ups
	public void  ToolTips (){
		if(PlayerPrefs.GetInt("ToolTips")==0){
			PlayerPrefs.SetInt("ToolTips",1);
		    tooltipstext.GetComponent<Text>().text = "on";
		}
		else if(PlayerPrefs.GetInt("ToolTips")==1){
			PlayerPrefs.SetInt("ToolTips",0);
			tooltipstext.GetComponent<Text>().text = "off";
		}
	}*/

	public void  ToolTipsOn (){
		//difficultynormaltext.GetComponent<Text>().text = "NORMAL";
		//difficultyhardcoretext.GetComponent<Text>().text = "hardcore";
		tooltipofftextLINE.gameObject.SetActive(false);
		tooltipontextLINE.gameObject.SetActive(true);
		PlayerPrefs.SetInt("ToolTipsOn",1);
		PlayerPrefs.SetInt("ToolTipsOff",0);
	}

	public void  ToolTipsOff (){
		//difficultynormaltext.GetComponent<Text>().text = "normal";
		//difficultyhardcoretext.GetComponent<Text>().text = "HARDCORE";
		tooltipofftextLINE.gameObject.SetActive(true);
		tooltipontextLINE.gameObject.SetActive(false);
		PlayerPrefs.SetInt("ToolTipsOn",0);
		PlayerPrefs.SetInt("ToolTipsOff",1);
	}
}