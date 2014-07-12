using UnityEngine;
using System.Collections;

public class TitleScenes : MonoBehaviour {

	void Start () {
	}

	void Update () {
		if (Input.GetKey (KeyCode.Space)||Input.touchCount == 1 || Input.GetMouseButtonDown(0)) {
			FadeManager.Instance.LoadLevel("Game",0.5f);;		
		}

	}
}
