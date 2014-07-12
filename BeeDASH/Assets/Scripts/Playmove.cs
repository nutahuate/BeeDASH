using UnityEngine;
using System.Collections;

public class Playmove : MonoBehaviour {

	private Vector3 move;

	private bool flag = false;

	// Use this for initialization
	void Start () {
		move = new Vector3(0.0f,-0.8f,-2.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (flag == false) {
						if (move.x <= 0.1f) {
								move.x += 0.01f;
						} else {
								flag = true;
						}

				} else {
					if (move.x >= -0.1f) {
						move.x -= 0.01f;
					} else {
						flag = false;
					}
				}
		transform.position = move;
	}
}
