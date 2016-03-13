using UnityEngine;
using System.Collections;

public class MarkerEvents : MonoBehaviour {

	public GUIText tipText;
	private GameState gameState;
	//private bool stop = false;


	// Use this for initialization
	void Start () {
		gameState = GetComponent<GameState> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			FoundMarker();
		}else if(Input.GetKeyDown (KeyCode.Q)){
			LosedMarker();
		}
	}

	public void FoundMarker(){
		if (gameState.gameOver)
			return;
		if (tipText != null) {
			tipText.enabled = false;
		}
		Time.timeScale = 1f;
	}

	public void LosedMarker(){
		if (gameState.gameOver)
			return;
		if (tipText != null) {
			tipText.enabled = true;
		}
		Time.timeScale = 0f;
	}
}
