using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Transform prefabHit;
	public float hitDelay = 0.5f;
	private float nextHit = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetButtonDown ("Fire1") || Input.touchCount > 0) && Time.time > nextHit) {
			nextHit = Time.time + hitDelay;
			Instantiate(prefabHit, transform.position, transform.rotation);
		}
	}
}
