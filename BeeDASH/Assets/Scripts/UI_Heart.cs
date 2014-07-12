using UnityEngine;
using System.Collections;

public class UI_Heart : MonoBehaviour {
    public static int m_hp;
    public int m_UICount;

	public GameObject beebaObj;

	private Beeba beeba;

	// Use this for initialization
	void Start () {
		this.beeba = beebaObj.GetComponent<Beeba>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(beeba.life < m_UICount)
        {
            renderer.enabled = false;
        }
        else
        {
            renderer.enabled = true;
        }
	}
}
