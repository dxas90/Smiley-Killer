using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static T getComponent<T>(string gameObjectName) where T : UnityEngine.Component{
		GameObject controller = GameObject.Find (gameObjectName);
		if (controller != null) {
			return controller.GetComponent<T> ();
		} else {
			Debug.LogError("GameObject with name "+gameObjectName+" not found");
			return null;
		}
	}
}
