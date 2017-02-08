using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawnerSpawner : MonoBehaviour {

	public GameObject birdSpawner;

	void Start () {
		InvokeRepeating ("MakeNewSpawner", 15f, 15f);
	}
		
	void MakeNewSpawner() {
		var allSpawners = GameObject.FindGameObjectsWithTag ("BirdSpawner");
		var oldSpawner = allSpawners[Random.Range(0, allSpawners.Length)];
		var newSpawner = Instantiate (oldSpawner) as GameObject;
		var spawner = newSpawner.GetComponent<Patroller> ();
		var position = spawner.transform.position;
		position.y = spawner.GetBottom();
		spawner.transform.position = position;
	}
}
