using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class PlayAgain : MonoBehaviour {

	public void RestartGame() {
		Application.LoadLevel ("Scene1");
	}
}
