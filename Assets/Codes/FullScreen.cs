using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullScreen : MonoBehaviour

    
{
    public Vector2 resolution;
    public Vector2 scale;
    public Sprite bg;
    public Text width;
    public Text height;
    void Awake()
    {

        
        scale = new Vector2(resolution.x, resolution.y);
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        
        transform.localScale = scale;
       
        /*float cameraHeight = Camera.main.orthographicSize;
        Vector2 cameraSize = new Vector2(Camera.main.aspect * cameraHeight, cameraHeight);
        Vector2 spriteSize = spriteRenderer.sprite.bounds.size;

        
       
        
        Vector2 scale = transform.localScale;
        if (cameraSize.x >= cameraSize.y)
        { // Landscape (or equal)
            scale *= cameraSize.x / spriteSize.x;
        }
        else
        { // Portrait
            scale *= cameraSize.y / spriteSize.y;
        }*/

        // transform.position = Vector2.zero; // Optional
        //transform.localScale = scale;
    }
    private void Update()
    {
        resolution = new Vector2(Screen.width, Screen.height);
        width.text = resolution.x.ToString();
        height.text = resolution.y.ToString();

    }
}
