using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	public float airValue;
	public float collidedValue;
	public float offScreenValue;

	private float point_value;

	void Start () {
		point_value = airValue;
	}

	void OnMouseEnter() {
		Destroy (this.gameObject);
		ScoreManager.AddScore (point_value);

		if (ScoreManager.Score > HighestScore.score) {
			HighestScore.score = ScoreManager.Score;
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Wall") {
			point_value = collidedValue;
		} else if (col.gameObject.tag == "Finish") {
			Destroy (gameObject);
			ScoreManager.AddScore (offScreenValue);
		}
	}
}
