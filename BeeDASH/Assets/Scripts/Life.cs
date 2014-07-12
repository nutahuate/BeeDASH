using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

	public GameObject beeba = null;
	public GameObject life  = null;

	private ArrayList lifes = new ArrayList();
	private Beeba player;

	// Use this for initialization
	void Start () {
		this.player = beeba.GetComponent<Beeba>();

		for (int i = 0; i < this.player.life; i++) {
			var obj = Instantiate(this.life) as GameObject;
			obj.transform.parent = this.transform;
			obj.name = "" + i;
			lifes.Add(obj);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
