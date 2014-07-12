using UnityEngine;
using System.Collections;

public class TitleScenes : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.touchCount == 1) 
		//{
			if (Input.GetMouseButtonDown(0)) {
				Vector2 tapPoint  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				Collider2D collition2d  = Physics2D.OverlapPoint(tapPoint);
				if (collition2d) {
				RaycastHit2D hitObject = Physics2D.Raycast(tapPoint,-Vector2.up);
					if (hitObject) {
						Debug.Log("hit object is " + hitObject.collider.gameObject.name);
						Application.LoadLevel ("Game");
					}
				}
			}
			
		//}
	}
}
