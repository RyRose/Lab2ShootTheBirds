using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawnerSpawner : MonoBehaviour {

	public GameObject birdSpawner;

	public float waitTime;
	public float initialTime;

	void Start () {
		InvokeRepeating ("MakeNewSpawner", initialTime, waitTime);
		InvokeRepeating ("FlipGravity", initialTime, waitTime + Random.Range (1, 5));
	}
		
	void MakeNewSpawner() {
		var allSpawners = GameObject.FindGameObjectsWithTag ("BirdSpawner");
		var oldSpawner = allSpawners[Random.Range(0, allSpawners.Length)];
		var _ = Instantiate (oldSpawner) as GameObject;
		if (allSpawners.Length == 50) {
			CancelInvoke ("MakeNewSpawner");
		}
	}

	void FlipGravity() {
		var birds = GameObject.FindGameObjectsWithTag ("Bird");
		foreach (GameObject bird in birds) {
			var rigidbody = bird.GetComponent<Rigidbody2D> ();
			rigidbody.gravityScale *= -1;
		}
	}
}