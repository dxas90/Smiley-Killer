using UnityEngine;
using System.Collections;

public class DestroyModel : MonoBehaviour {

	public float lifeTime = 2f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
