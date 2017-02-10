using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawnerSpawner : MonoBehaviour {

	public GameObject birdSpawner;

	public float waitTime;
	public float initialTime;

	void Start () {
		InvokeRepeating ("MakeNewSpawner", initialTime, waitTime);
	}
		
	void MakeNewSpawner() {
		var allSpawners = GameObject.FindGameObjectsWithTag ("BirdSpawner");
		var oldSpawner = allSpawners[Random.Range(0, allSpawners.Length)];
		var _ = Instantiate (oldSpawner) as GameObject;
		if (allSpawners.Length == 50) {
			CancelInvoke ("MakeNewSpawner");
		}
	}
}