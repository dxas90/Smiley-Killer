using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {

	public Transform enemyModel;
	public Transform objectFlyAround;
	public Transform enemyParent;

	public float delayToStart = 3f;
	public float delayBetweenGhost = 5f;

	private float nextTimeSmiley;

	// Use this for initialization
	void Start () {
		nextTimeSmiley = Time.time + delayToStart;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= nextTimeSmiley) {
			nextTimeSmiley = Time.time + delayBetweenGhost;
			Transform newSmiley = Instantiate(enemyModel, objectFlyAround.transform.position, objectFlyAround.transform.rotation) as Transform; //casting
			newSmiley.parent = enemyParent;
			Rotate rotate = newSmiley.GetComponent<Rotate>();
			rotate.rotationCenterObject = objectFlyAround;
		}
	}
}
