using System.Collections;
using System.Collections.Generic;

public class ScoreManager {

	public static float Score {
		get;
		set;
	}

	public static void AddScore(float points) {
		Score += points;
	}
}
