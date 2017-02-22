using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour {

	public GameObject musicOnBtn;
	public GameObject musicOffBtn;
	public GameObject returnBtn;
	public GameObject optionScrn;
	public GameObject pauseScrn;

	public AudioSource backGroundMusic;

	public void turnOn(){
		backGroundMusic.UnPause();
	}
		
	public void turnOff(){
		backGroundMusic.Pause();
	}

	public void goBack(){
		optionScrn.SetActive (false);
		pauseScrn.SetActive (true);
	}
}
