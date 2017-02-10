using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public int level_length;

	private int start;

	public void Start() {
		start = Mathf.FloorToInt (Time.time);
		ScoreManager.Score = 0;
	}

	public void Update() {
		Text text = GetComponent<Text> ();
		int time = Mathf.FloorToInt (Time.time);
		text.text = "" + (time - start);

		if ((time - start) == level_length) {
			SceneManager.LoadScene (1);
		}

	}
}
