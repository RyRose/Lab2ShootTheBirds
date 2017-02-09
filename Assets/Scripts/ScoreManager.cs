using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager {

	private static ScoreManager manager;

	public static ScoreManager getScoreManager() {
		if (manager == null) {
			manager = new ScoreManager();
		}
		return manager;
	}

	public float Score {
		get;
		set;
	}

	public void addScore(float points) {
		Score += points;
		Debug.Log (Score);
	}
}
