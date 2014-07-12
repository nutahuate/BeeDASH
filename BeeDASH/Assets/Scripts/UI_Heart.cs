using UnityEngine;
using System.Collections;

public class UI_Heart : MonoBehaviour {
    public static int m_hp;
    public int m_UICount;

	// Use this for initialization
	void Start () {
        //m_pPlayer = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	    if(m_hp < m_UICount)
        {
            renderer.enabled = false;
        }
        else
        {
            renderer.enabled = true;
        }
	}
}
