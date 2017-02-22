using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour {

	public GameObject pauseBtn;
	public GameObject score;
	public GameObject hScore;
	public GameObject jumpBtn;



	public string mainMenu;

	void Start () {



		pauseBtn.SetActive (false);
		score.SetActive (false);
		hScore.SetActive (false);
		jumpBtn.SetActive (false);
	}


	public void toMenu(){

		SceneManager.LoadScene (mainMenu);
	}


}
