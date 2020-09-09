using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchBehavior : MonoBehaviour
{

    public Text text;
    public Touch touch;
    private float timeTouchEnded;
    private float displayTime = .5f;
    public Text text3;


    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount  > 0)
        {
            touch = Input.GetTouch(0);
            text.text = touch.phase.ToString();
            
            if(touch.phase == TouchPhase.Ended)
            {
                timeTouchEnded = Time.time;

            }
        }
        else if (Time.time - timeTouchEnded  > displayTime)
        {
            text.text = "";
        }
    }
}
