using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animation : MonoBehaviour
{

    public Sprite[] images;
    public Image animatedObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animatedObj.sprite = images[(int)(Time.time * 3) % images.Length];
    }
}
