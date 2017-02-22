using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	public GameObject startBtn;
	public GameObject pauseBtn;


	public void startGame(){

		Time.timeScale = 1f;
		startBtn.SetActive (false);
		pauseBtn.SetActive (true);
	}


}
