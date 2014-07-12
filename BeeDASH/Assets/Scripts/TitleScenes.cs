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

//		Vector2 tapPoint  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//		Collider2D collition2d  = Physics2D.OverlapPoint(tapPoint);
//		RaycastHit2D hitObject = Physics2D.Raycast(tapPoint,-Vector2.up);
//
//			if (Input.GetMouseButtonDown(0)) {
//				if (collition2d) 
//				{
//					if (hitObject) 
//					{
						//Application.LoadLevel ("Game");
			//		}		
			//	}
			//}
			
		//}

		Ray ray ;//光線
		RaycastHit hit ;//光線が当たったときの情報が入ります
		Camera myCamera;//カメラを指定します。
			
			if(Input.touchCount == 1) {//タップあり時にtrue
				　　　　　　 Touch touch = Input.touches[0];
				　　　      　ray = myCamera.ScreenPointToRay(Input.touches[0].position);
				
				　　　　　　 if(touch.phase == TouchPhase.Ended && Physics.Raycast(ray.origin,ray.direction,out hit,Mathf.Infinity)){
					
					
					if(hit.collider==gameObject.collider){
						
						Application.LoadLevel ("Game");
						
						
					　　　}
					
				　 }
			}
	}
}
