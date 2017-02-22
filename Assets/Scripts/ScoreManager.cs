using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text score;
	public float scoreVal;

	public Text highScore;
	public float highScoreVal;

	public float scorePerSec;
	public bool scoreUp;

	public Text highScoreMenu;

	// Use this for initialization
	void Awake () {
		highScoreVal = PlayerPrefs.GetInt ("bestScore");
		scoreVal = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (scoreUp) {
			scoreVal += scorePerSec * Time.deltaTime;
		}
			
		score.text = "Score: " + Mathf.Round(scoreVal);
		highScore.text = "High Score: " + PlayerPrefs.GetInt ("bestScore");
		highScoreMenu.text = "You scored "  + Mathf.Round(scoreVal)+ "!";

		if (scoreVal > highScoreVal) {
			highScoreVal = scoreVal;
			PlayerPrefs.SetInt ("bestScore", (int)highScoreVal);
		}
	}

	void onDestroy(){
		PlayerPrefs.SetInt ("bestScore", (int) highScoreVal);

		PlayerPrefs.Save ();
	}
}
