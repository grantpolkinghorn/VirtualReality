using UnityEngine;
using System.Collections;
using UnityEngine.Rendering.PostProcessing;

public class CheckBrightness : MonoBehaviour {
	
	
	PostProcessVolume m_Volume;
	ColorGrading m_ColorGrading;
	

	public void  Start (){
		// remember volume level from last time
		 
		m_ColorGrading = ScriptableObject.CreateInstance<ColorGrading>();
		m_ColorGrading.enabled.Override(true);
		m_ColorGrading.postExposure.Override(1f);
		m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, m_ColorGrading);
//		
	}

	public void Update(){
		var new_bright = PlayerPrefs.GetFloat("Brightness");
		//Debug.Log(PlayerPrefs.GetFloat("Brightness"));
		m_ColorGrading.postExposure.value = new_bright;
//		
	}
}
