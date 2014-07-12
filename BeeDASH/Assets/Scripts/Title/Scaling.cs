using UnityEngine;
using System.Collections;

public class Scaling : MonoBehaviour {

	private float Scale;

	// Use this for initialization
	void Start () {
		Scale = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (Scale <= 0.8f)
		{
				Scale += 0.05f;
		}

		transform.localScale = new Vector3 (Scale, Scale, Scale);
	}
}
