using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour {

	public void Update() {
		Text text = GetComponent<Text> ();
		text.text = "" + ScoreManager.Score;
	}
}
