using UnityEngine;
using System.Collections;

public class TitleMovement : MonoBehaviour {

	private Vector3 move;

	// Use this for initialization
	void Start () {
		move = new Vector3(-6.0f,0.25f,0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		move.x += 0.05f;
		if(move.x >= 6.0f)
		{
			move.x = -6.0f;
		}
		transform.position = move;
	}
}
