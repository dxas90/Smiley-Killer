using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public Transform rotationCenterObject;
	public float rotationBySec = 75f; 

	public float actualRadio = 2f;
	public float incrementRadioBySec = 0.3f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		actualRadio += incrementRadioBySec * Time.deltaTime;

		transform.position = new Vector3 (rotationCenterObject.position.x, transform.position.y, rotationCenterObject.position.z);

		transform.Translate (-actualRadio, 0, 0);

		transform.RotateAround (rotationCenterObject.position, Vector3.up, rotationBySec * Time.deltaTime);
	}
}
