using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate : MonoBehaviour
{
    public GameObject car;
    public SpriteRenderer sr;
    public Color blue;
    public Color green;
    public Color red;
    public Color black;
    public string currentColor;
    void Start()
    {
        SetRandomColor();
    }
    private void SetRandomColor()
    {

        int ran = UnityEngine.Random.Range(0, 3);
        switch (ran)
        {
            case 0:
                  
                currentColor = "Blue";
                sr.color = blue;
                break;
            case 1:
                currentColor = "Green";
                sr.color = green;
                break;
            case 2:
                currentColor = "Red";
                sr.color = red;
                break;
            case 3:
                currentColor = "Black";
                sr.color = black;
                break;

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag.Equals("car"))
        {

            Destroy(collision.gameObject);
            Debug.Log("Something");
            SetRandomColor();
            Instantiate(car, new Vector2(6.29f, -3.07f), transform.rotation);

        }
    }
}
