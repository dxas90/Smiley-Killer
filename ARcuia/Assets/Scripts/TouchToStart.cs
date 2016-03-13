using UnityEngine;
using System.Collections;

public class TouchToStart : MonoBehaviour {

	public string sceneName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") || Input.touchCount > 0) {
			Application.LoadLevel(sceneName);
		}
	}
}
