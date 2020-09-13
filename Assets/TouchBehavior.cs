using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchBehavior : MonoBehaviour
{

    public GameObject Car;
    public SpriteRenderer sr;
    public Touch touch;
    private float timeTouchEnded;
    private float displayTime = .5f;
    


    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount  > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
              

            }
            touch.phase.ToString();
            
            if(touch.phase == TouchPhase.Ended)
            {
                timeTouchEnded = Time.time;

            }
        }
        else if (Time.time - timeTouchEnded  > displayTime)
        {
            
        }
    }
}
