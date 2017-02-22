using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Transform platformGenerator;
  

	public ScrollingBackground background;

    public PlayerController player;
    

    //private PlatformDestroyer[] platformList;
	public GameObject instructions;

	private ScoreManager scoreMan;
	public DeathScreen deathMenu;

	// Use this for initialization
	void Start () {
		scoreMan = FindObjectOfType<ScoreManager>();
		StartCoroutine (Instructions ());
	}
		

    public void RestartGame()
    {
		background.GetComponent<ScrollingBackground> ().speed = 0;
		scoreMan.scoreUp = false;
		player.gameObject.SetActive(false);
		deathMenu.gameObject.SetActive (true);
    }

    public void Reset()
    {
		SceneManager.LoadScene("MainScene");

    }
    
	IEnumerator Instructions(){
		
		yield return new WaitForSeconds(2f);
		instructions.SetActive (false);


	}
}
