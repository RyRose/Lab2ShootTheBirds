using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlipper : MonoBehaviour {

	public string tag;
	public float waitTime;
	public float initialTime;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("FlipGravity", initialTime, waitTime + Random.Range (1, 5));
	}

	void FlipGravity() {
		var objects = GameObject.FindGameObjectsWithTag (tag);
		foreach (GameObject obj in objects) {
			var rigidbody = obj.GetComponent<Rigidbody2D> ();
			rigidbody.gravityScale *= -1;
		}
	}
}
