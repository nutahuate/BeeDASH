using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public static GameObject m_pPlayer = null;
    
	// Use this for initialization
	void Start () {
        m_pPlayer = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3( m_pPlayer.transform.position.x,m_pPlayer.transform.position.y,-10);
	}
}
