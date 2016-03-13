using UnityEngine;
using System.Collections;

public class SmileyBehavior : MonoBehaviour {

	public Transform killAnimation;

	private GameState gameState;
	// Use this for initialization
	void Start () {
		gameState = GameController.getComponent<GameState> ("GameController");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Killed(){
		Rotate rotate = transform.parent.GetComponent<Rotate> ();
		SmileyGoOut ghostOut = transform.parent.GetComponent<SmileyGoOut> ();

		int score = (int)((100 * rotate.actualRadio) / ghostOut.radioToRemove);

		gameState.incScore (score);

		Instantiate (killAnimation, transform.position, transform.rotation);
		Destroy (gameObject.transform.parent.gameObject);
	}
}
