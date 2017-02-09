using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour {

	public Vector2 start;
	public Vector2 end;
	public float speed;

	private Vector2 destination;

	void Start() {
		transform.position = start;
	}

	void Update () {
		if (Vector2.Distance(start, transform.position) < 0.5) {
			destination = end;
		} else if (Vector2.Distance(end, transform.position) < 0.5) {
			destination = start;
		}

		Vector2 pos = Vector2.MoveTowards (transform.position, destination, speed * Time.deltaTime);
		transform.position = pos;
	}
}
