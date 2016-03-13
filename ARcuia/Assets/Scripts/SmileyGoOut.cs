using UnityEngine;
using System.Collections;

public class SmileyGoOut : MonoBehaviour {

	public float radioToRemove = 12f;

	private Rotate rotate;

	private GameState gameState;

	public AudioClip outSound;

	// Use this for initialization
	void Start () {
		rotate = GetComponent<Rotate>();
		gameState = GameController.getComponent<GameState> ("GameController");
	}
	
	// Update is called once per frame
	void Update () {
		if (rotate.actualRadio >= radioToRemove) {
			smileytOut();
		}
	}

	private void smileytOut(){
		gameState.LooseLife ();
		AudioSource.PlayClipAtPoint (outSound, transform.position);
		Destroy(gameObject);


	}
}
