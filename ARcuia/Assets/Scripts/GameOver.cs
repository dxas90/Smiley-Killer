using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	private GameState gameState;
	public GUIText scoreText;
	public GameObject camera;
	private float nextRoundDelay = 4;
	private float timeToReturn;

	public string sceneName;
	// Use this for initialization
	void Start () {
		gameState = GetComponent<GameState> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameState.gameOver 
		    &&(Input.GetButtonDown("Fire1") || Input.touchCount>0)
		    && Time.realtimeSinceStartup > timeToReturn)
			{
				Time.timeScale = 1f;
				Application.LoadLevel(sceneName);
			}
	}

	public void FinishGame(){
		timeToReturn = Time.realtimeSinceStartup + nextRoundDelay;

		gameState.gameOver = true;
		Time.timeScale = 0f;

		camera.SetActiveRecursively (true);

		if(gameState.score > gameState.highScore){
			gameState.highScore = gameState.score;
			PlayerPrefs.SetInt("highScore", gameState.score);
			scoreText.guiText.text = "Got it, record! " + gameState.score.ToString("D5");
		}else{
			scoreText.guiText.text = gameState.score.ToString("D5");
		}
	}
}
