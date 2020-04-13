using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour {
	public bool isEscapeToExit;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) {
			if (isEscapeToExit) {
				Application.Quit ();
				Debug.Log("Game is exiting");
			} 
			else {
				Menu ();
			}
		}
	}

	public void Mulai () {
		SceneManager.LoadScene ("Main");
	}

	public void Menu () {
		SceneManager.LoadScene ("Menu");
	}

	public void Help () {
		SceneManager.LoadScene ("HowToPlay");
	}

	public void Credit () {
		SceneManager.LoadScene ("Credit");
	}

	public void Quit () {
		Application.Quit ();
		Debug.Log("Game is exiting");
	}
}