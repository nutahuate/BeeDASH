using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public GameObject m_pPlayer = null;
    
	// Use this for initialization
	void Start () {
        m_pPlayer = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3( m_pPlayer.transform.position.x,0,-30);
	}
}
