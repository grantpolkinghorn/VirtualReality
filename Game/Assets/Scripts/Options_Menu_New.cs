using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Options_Menu_New : MonoBehaviour
{
    // sliders

    public GameObject brightnessSlider;


//    public void Start()
//    {
 //       var brightnessSliderValue = brightnessSlider.GetComponent<Slider>().value;
//        PlayerPrefs.SetFloat("Brightness", brightnessSliderValue);
//        brightnessSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("Brightness");

//    }

    public void Update()
    {
       var brightnessSliderValue = brightnessSlider.GetComponent<Slider>().value;
       PlayerPrefs.SetFloat("Brightness", brightnessSliderValue);
       Debug.Log(PlayerPrefs.GetFloat("Brightness"));

    }


    //    public void BrightnessSlider()
    //   {
    //       PlayerPrefs.SetFloat("Brightness", brightnessSliderValue);
    //   }

}