using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	public GUITexture lifesGUI;
	public GUIText scoreGUI;

	public Texture[] imageLife;
	public int actualLifes = 0;
	public int initLifes = 3;

	public int score = 0;

	internal bool gameOver = false;
	internal int highScore = 0;
	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetInt ("highScore", score);

		actualLifes = initLifes;
		lifesGUI.guiTexture.texture = imageLife [actualLifes];
		score = 0;
		updateScore ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void updateScore(){
		scoreGUI.text = score.ToString ("D5");
	}

	public void LooseLife(){
		if (actualLifes > 0) {
			actualLifes--;
		}

		if (actualLifes < imageLife.Length) {
			lifesGUI.guiTexture.texture = imageLife [actualLifes];
		}

		if (actualLifes <= 0) {
			SendMessage("FinishGame", SendMessageOptions.DontRequireReceiver);
		}
	}

	public void incScore(int points){
		score = score + points;
		updateScore ();
	}
}
