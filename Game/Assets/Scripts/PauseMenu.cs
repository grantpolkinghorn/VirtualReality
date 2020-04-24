using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;
    public RectTransform PauseMenuTransform;
    public GameObject Cam;
    public GameObject Player;
    public Transform Kitchen;
    public Transform Living_Room;
    public Transform Bathroom;
    public Transform PauseMenuUI_New;
	public GameObject PanelControls;
	public GameObject PanelLocation;
	public GameObject PanelControlsHighlight;
	public GameObject PanelLocationHighlight;
    public GameObject Pointer;
    public GameObject Elton;
    public GameObject Ocean;

    // Update is called once per frame
    public void Press () {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
	}
    void Resume()
    {
        //PauseMenuUI.SetActive(false);
        Pointer.SetActive(false);
        GameIsPaused = false;
    }
    void Pause()
    {
        //PauseMenuTransform.position = PauseMenuUI_New.transform.position;
        //PauseMenuTransform.LookAt(Cam.transform.position);
        //PauseMenuTransform.eulerAngles = new Vector3(180, PauseMenuTransform.eulerAngles.y, 180);  
        //PauseMenuUI.SetActive(true);
        GameIsPaused = true;
        Pointer.SetActive(true);


    }

    public void Move_To_Kitchen()
    {
        Player.transform.position = Kitchen.transform.position;
        Cam.transform.position = Kitchen.transform.position;
        Resume();
    }
    public void Move_To_Bathroom()
    {
        Player.transform.position = Bathroom.transform.position;
        Cam.transform.position = Kitchen.transform.position;
        Resume();
    }

    public void Move_To_LivingRoom()
    {
       Player.transform.position = Living_Room.transform.position;
        Cam.transform.position = Kitchen.transform.position;
        Resume();
    }
    public void Menu_Return(int sceneIndex)
    {
		Resume();
        SceneManager.LoadScene(sceneIndex);
    }
	public void  LocationPanel (){
		PanelLocation.gameObject.SetActive(true);
		PanelControls.gameObject.SetActive(false);

		PanelLocationHighlight.gameObject.SetActive(true);
		PanelControlsHighlight.gameObject.SetActive(false);
	}
	public void  ControlsPanel (){
		PanelLocation.gameObject.SetActive(false);
		PanelControls.gameObject.SetActive(true);

		PanelLocationHighlight.gameObject.SetActive(false);
		PanelControlsHighlight.gameObject.SetActive(true);
	}

    public void EltonOn ()
    {
        Elton.SetActive(true);
        Ocean.SetActive(false);
    }

    public void OceanOn()
    {
        Elton.SetActive(false);
        Ocean.SetActive(true);
    }
}
