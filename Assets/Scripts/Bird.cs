using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

	void OnMouseEnter() {
		Destroy (this.gameObject);
	}
}
