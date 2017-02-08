using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour {

	public GameObject birdPreFab;
	public float initialBirdSpeed;
	public float initialBirdAngle;

	void Start () {
		Invoke ("ShootBird", Random.Range(0.5f, 3f));
	}

	void ShootBird() {
		float angle = Mathf.Deg2Rad * initialBirdAngle;
		GameObject bird = Instantiate (birdPreFab) as GameObject;
		bird.transform.position = transform.position;
		Rigidbody2D body = bird.GetComponent<Rigidbody2D> ();
		body.velocity = new Vector2(Mathf.Cos (angle), Mathf.Sin (angle)) * initialBirdSpeed;
		Invoke ("ShootBird", Random.Range(0.5f, 3f));
	}
}
