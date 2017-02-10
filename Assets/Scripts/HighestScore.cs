using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighestScore : MonoBehaviour {
	public static float score = 0;
	// Use this for initialization
	void Start () {
		
	}

	void Awake() {
		if (PlayerPrefs.HasKey ("ShootBirdHighScore")) {
			score = PlayerPrefs.GetFloat ("ShootBirdHighScore");
		}

		PlayerPrefs.SetFloat ("ShootBirdHighScore", score);
	}
	// Update is called once per frame
	void Update () {
		Text text = this.GetComponent<Text> ();
		text.text = "" + score;

		if (score > PlayerPrefs.GetFloat("ShootBirdHighScore")) {
			PlayerPrefs.SetFloat("ShootBirdHighScore", score);
		}
	}
}
