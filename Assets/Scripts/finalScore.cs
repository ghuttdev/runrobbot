using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour {

	public ScoreManager score;
	public Text scoreTxt;


	void Start () { 
		scoreTxt = score.GetComponent<ScoreManager> ().score;
	}

	void Update () {
		
	}
}
