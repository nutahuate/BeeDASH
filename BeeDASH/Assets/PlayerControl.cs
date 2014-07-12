using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public int m_hp;

    private int UpCount;
    private int DownCount;

	// Use this for initialization
	void Start () {
        QualitySettings.vSyncCount = 0; // VSyncをOFFにする
        Application.targetFrameRate = 60; // ターゲットフレームレートを60に設定
        m_hp = 3;
	}
	
	// Update is called once per frame
	void Update () {
        //移動
        float speedf = 1.0f / 60.0f;
        Vector3 speed = new Vector3(speedf, 0.0f, 0.0f);

        foreach (var touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                // 現在のタッチ位置からRaycast
                if( touch.position.x <= Screen.height/2 )
                {
                    UpCount = 300;
                }
                else
                {
                    DownCount = 300;
                }
            }
        }

       //if (AndroidInput.touchCountSecondary > 0)
       //{

       //    string touchPhase = AndroidInput.GetSecondaryTouch(0).phase.ToString();

       //    if (touchPhase == "Moved")
       //    {

       //        float slideDirection = AndroidInput.GetSecondaryTouch(0).deltaPosition.x;

       //        //adjust sensitivity using amount
       //        if (slideDirection > 15.0f)
       //        {
       //            //guiText.text = "Slide Forward";
       //            float tempSpeedf = 2000;
       //            Vector3 tempSpeed = new Vector3(tempSpeedf,0.0f,0.0f);
       //            speed 

       //        }
       //        else if (slideDirection < -15.0f)
       //        {
       //            //guiText.text = "Slide Back";
       //        }
       //        else if (slideDirection < 4.0f || slideDirection > -4.0f)
       //        {
       //            //guiText.text = "Touch";
       //        }

       //    }
       //    else if (touchPhase == "Canceled")
       //    {
       //        //guiText.text = "Canceled";
       //        Application.Quit();
       //    }

       //}
 

        //
        transform.position += speed;
	}

    void AnimationUp(float Time)
    {

    }

    void AnimationDown(float Time)
    {

    }

}
