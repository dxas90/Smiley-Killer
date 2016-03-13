using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce (transform.forward * 1000);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "Floor") {
			removeHit();
		} else if (other.tag == "Enemy") {
			other.SendMessage("Killed", SendMessageOptions.DontRequireReceiver);
			removeHit();
		}
	}

	void removeHit(){
		Destroy (gameObject, 0.1f);
		GetComponentInChildren<ParticleSystem> ().enableEmission = false;	
	}
}
