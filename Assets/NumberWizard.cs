using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;
	public int maxGuessesAllowed = 5;

	public Text text;
	public Text remainText;

	// Use this for initialization
	void Start () {
		startGame ();
	}

	void startGame() {
		max = 1000;
		min = 1;
		nextGuess ();
	}

	public void GuessLower() {
		max = guess;
		nextGuess ();
	}

	public void GuessHigher() {
		min = guess;
		nextGuess ();
	}

	void nextGuess() {
		guess = Random.Range (min, max+1);
		text.text = guess.ToString();
		maxGuessesAllowed -= 1;

		remainText.text = "Remaining Guesses: " + maxGuessesAllowed.ToString ();

		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel ("Win");
		}
	}
}
