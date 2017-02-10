﻿using System.Collections;
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
		print (ScoreManager.getScoreManager ().Score);
		ScoreManager.getScoreManager ().addScore (point_value);

		if (ScoreManager.getScoreManager ().Score > HighestScore.score) {
			HighestScore.score = ScoreManager.getScoreManager ().Score;
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		print (col.gameObject.tag);
		if (col.gameObject.tag == "Wall") {
			point_value = collidedValue;
		} else if (col.gameObject.tag == "Finish") {
			Destroy (gameObject);
			ScoreManager.getScoreManager().addScore (offScreenValue);
		}
	}
}
