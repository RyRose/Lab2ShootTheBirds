using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	public GUIText scoreGT;

	void Start () {

		GameObject scoreGo = GameObject.Find ("ScoreCounter");

		scoreGT = scoreGo.GetComponent<GUIText> ();

		//scoreGT.text = "0";
		
	}
	
	void Update () {
		
	}

	void OnMouseEnter() {
		Destroy (this.gameObject);

		int score = int.Parse (scoreGT.text);
		score += 1;
		scoreGT.text = score.ToString ();
	}
}
