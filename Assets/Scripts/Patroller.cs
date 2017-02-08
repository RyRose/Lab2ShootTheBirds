using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour {

	public float speed;
	public Camera camera;
	
	void Update () {
		Vector2 pos = transform.position;
		pos.y += speed * Time.deltaTime;
		transform.position = pos;

		if (pos.y > GetTop())
		{
			speed = -Mathf.Abs(speed);
		} else if (pos.y < GetBottom())
		{
			speed = Mathf.Abs(speed);
		} 
	}

	public float GetTop() {
		return camera.ViewportToWorldPoint (new Vector2 (0, 0.8f)).y;
	}
	public float GetBottom() {
		return camera.ViewportToWorldPoint (new Vector2 (0, 0.1f)).y;
	}
}
