using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public int m_hp ;

    private Vector3 position;
	private bool animation_now = false;

	// Use this for initialization
	void Start () {
        QualitySettings.vSyncCount = 0; // VSyncをOFFにする
        Application.targetFrameRate = 60; // ターゲットフレームレートを60に設定
        m_hp = 3;
	}
	
	// Update is called once per frame
	void Update () {

		if (!this.animation_now)
		{
	        if (Input.GetKeyDown("up"))
	        {
				StartCoroutine("AnimationUp");
			}
	        if (Input.GetKeyDown("down"))
	        {
				StartCoroutine("AnimationDown");
			}
        }

        //移動
        float speedf = 2.0f / 60.0f;
        Vector3 speed = new Vector3(speedf, 0.0f, 0.0f);
        position = transform.position;
        transform.position += speed;
	}

	public IEnumerator AnimationUp()
    {
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
	public IEnumerator AnimationDown()
    {
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
