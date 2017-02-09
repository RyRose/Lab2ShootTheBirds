using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour {

	public GameObject birdPreFab;
	public float initialBirdForce;
	public float initialBirdAngle;

	void Start () {
		Invoke ("ShootBird", Random.Range(0.5f, 3f));
	}

	void ShootBird() {
		float angle = Mathf.Deg2Rad * (initialBirdAngle + Random.Range(-45, 45));
		GameObject bird = Instantiate (birdPreFab) as GameObject;
		bird.transform.position = transform.position;
		Rigidbody2D body = bird.GetComponent<Rigidbody2D> ();
		body.AddForce (new Vector2 (Mathf.Cos (angle), Mathf.Sin (angle)) * (initialBirdForce * Random.Range(0.5f, 2f)));
		Invoke ("ShootBird", Random.Range(0.5f, 3f));
	}
}
