using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public int m_hp ;

    private static int SinCount;
    private static int s_MoveCount;
    private static Vector3 position;

	// Use this for initialization
	void Start () {
        QualitySettings.vSyncCount = 0; // VSyncをOFFにする
        Application.targetFrameRate = 60; // ターゲットフレームレートを60に設定
        SinCount = 0;
        m_hp = 3;
	}
	
	// Update is called once per frame
	void Update () {
        //移動
        float speedf = 1.0f / 60.0f;
        Vector3 speed = new Vector3(speedf, 0.0f, 0.0f);       

        position = transform.position;

        //foreach (var touch in Input.touches)
        //{

        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        // 現在のタッチ位置からRaycast
        //        if( touch.position.x <= Screen.height/2 )
        //        {
        //            UpCount = 300;
        //        }
        //        else
        //        {
        //            DownCount = 300;
        //        }
        //    }
        //}
        
        if (Input.GetMouseButtonDown(0))
        {
            //if (UpCount < 0 && DownCount < 0)            
            {
                if (Input.mousePosition.y <= Screen.height / 2.0f)
                {
                    s_MoveCount += 30;
                }
                else
                {
                    s_MoveCount -= 30;
                }
            }
        }
        

        //AnimationUp();
        //AnimationDown();

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
        
        if(s_MoveCount != 0)
        {
            SinCount += (s_MoveCount/60);
            if(s_MoveCount < 0)
            {
                s_MoveCount--;
            }
            else
            {
                s_MoveCount++;
            }
        }

        position.y = Mathf.Sin((float)SinCount/30.0f);
 

        //
        transform.position = position + speed;
	}

    void AnimationUp()
    {
        {
            position.y = Mathf.Sin((float)SinCount/60);
        }
    }

    void AnimationDown()
    {
        {
            position.y = (Mathf.Sin((float)SinCount/60.0f))*-1.0f;
        }
    }
}
