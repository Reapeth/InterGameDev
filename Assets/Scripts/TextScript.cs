using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {
	public Text textDisplay;
	float currentDistance;
	Vector3 playerPos;
	Vector3 treasurePos;
	bool winning = false;
	void Start () {
		playerPos = GameObject.Find ("Player").GetComponent<Transform> ().position;
		treasurePos = GameObject.Find ("Treasure").GetComponent<Transform> ().position;
		currentDistance = Vector3.Distance (playerPos, treasurePos);
	}
	void Update () {
		playerPos = GameObject.Find ("Player").GetComponent<Transform> ().position;
		treasurePos = GameObject.Find ("Treasure").GetComponent<Transform> ().position;
		currentDistance = Vector3.Distance (playerPos, treasurePos);
		if (currentDistance > 7f) {
			textDisplay.text = "You're getting colder!";
		} else if (currentDistance <= 7f && currentDistance > 5f) {
			textDisplay.text = "You're cold!";
		} else if (currentDistance <= 5f && currentDistance > 4f) {
			textDisplay.text = "You're cold...";
		} else if (currentDistance <= 4f && currentDistance > 3f) {
			textDisplay.text = "You're warm...";
		} else if (currentDistance <= 3f && currentDistance > 2f) {
			textDisplay.text = "You're getting warmer...";
		} else if (currentDistance <= 2f && currentDistance > 1f) {
			textDisplay.text = "You're getting warmer!";
		} else if (currentDistance <= 1f && currentDistance > 0.5f) {
			textDisplay.text = "You're hot!";
		} else {
			if (Input.GetKeyDown (KeyCode.Space)) {
				winning = true;
			}
			if (winning == true) {
				textDisplay.text = "You won!";
			}
			else if (winning == false){
				textDisplay.text = "You found the treasure! Press [SPACE] to claim it!";
			}
		}
	}
}
