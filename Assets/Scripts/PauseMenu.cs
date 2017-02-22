using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

	public string mainMenu;
	public GameObject pauseScrn;
	public GameObject pauseBtn;
	public GameObject jumpBtn;
	public GameObject optionScreen;
	public AudioSource backGroundMusic;


	public void resumeGame(){

		Time.timeScale = 1f;
		pauseScrn.SetActive (false);
		pauseBtn.SetActive (true);
		jumpBtn.SetActive (true);



	}

	public void pauseGame(){

		Time.timeScale = 0f;
		pauseScrn.SetActive (true);
		pauseBtn.SetActive (false);
		jumpBtn.SetActive (false);

	}


	public void toMenu(){
		
		Time.timeScale = 1f;
		SceneManager.LoadScene (mainMenu);
	}

	public void Options(){
		pauseScrn.SetActive (false);
		optionScreen.SetActive (true);
	}
}
