using UnityEngine;
using System.Collections;

public class Beeba : MonoBehaviour {

	public float speed = 1.0f;
	public int life = 3;

	private bool animation_now = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		this.Move();
		this.SyncCameraPos();

		if (this.life <= 0) {
			FadeManager.Instance.LoadLevel("Title",0.2f);
		}
	}

	private void SyncCameraPos() {
		var pos = Camera.main.transform.position;
		pos.x = transform.position.x;
		Camera.main.transform.position = pos;
	}

	private void Move () {
		var pos = transform.position;
		pos.x += speed * 0.1f;
		transform.position = pos;

		if (Input.GetMouseButtonDown(0)) {
			if (Input.mousePosition.y > Screen.height / 2.0f) {
				StartCoroutine("Jump");
			}
			else {
				StartCoroutine("Dive");
			}
		}
	}

	private IEnumerator Jump()
	{
		if (!animation_now) {
			animation_now = true;
			for (int i = 0; i < 100; i++) {
				var pos = transform.position;
				pos.y = Mathf.Sin(i / 25.0f);
				pos.y = pos.y < 0 ? 0 : pos.y;
				transform.position = pos;
				yield return null;
			}
			animation_now = false;
		}
	}

	private IEnumerator Dive()
	{
		if (!animation_now) {
			animation_now = true;
			for (int i = 0; i < 100; i++) {
				var pos = transform.position;
				pos.y = -Mathf.Sin(i / 25.0f);
				pos.y = pos.y > 0 ? 0 : pos.y;
				transform.position = pos;
				yield return null;
			}
			animation_now = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.name == "ikada" ||
		    other.name == "iwa") {
			--this.life;
			Debug.Log(this.life);
		}
	}
}
