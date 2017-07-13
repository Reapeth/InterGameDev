using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (new Vector3 (0, 0, 3f) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (new Vector3 (0, 0, -3f) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (new Vector3 (-3f, 0, 0) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (new Vector3 (3f, 0, 0) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Rotate (new Vector3 (-75f, 0, 0) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Rotate (new Vector3 (75f, 0, 0) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (new Vector3 (0, -75f, 0) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (new Vector3 (0, 75f, 0) * Time.deltaTime);
		}
	}
}
