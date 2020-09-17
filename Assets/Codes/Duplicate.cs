using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Duplicate : MonoBehaviour
{
    public GameObject car;
    SpriteRenderer sr;
    public Color orange;
    public Color green;
    public Color brown;
    public int ran;
    public Text btnOrangeScore;
    public Text btnGreenScore;
    public Text btnBrownScore;
    int scoreCounterOrange  = 0;
    int scoreCounterGreen = 0;
    int scoreCounterBrown = 0;
    public Button btnOrange;
    public Button btnGreen;
    public Button btnBrown;
    public GameObject instantiated;
    public string currentColor;
    void Start()
    {
        instantiated = Instantiate(car, new Vector2(6.29f, -3.07f), transform.rotation);
        sr = instantiated.GetComponent<SpriteRenderer>();
        SetRandomColor();
        btnOrangeScore.text = scoreCounterOrange.ToString();
        btnGreenScore.text = scoreCounterGreen.ToString();
        btnBrownScore.text = scoreCounterBrown.ToString();


    }

    public void checkCarColorOrange()
    {
        if(instantiated != null)
        {
            if(sr.color == orange)
            {
                scoreCounterOrange++;
                btnOrangeScore.text = scoreCounterOrange.ToString();
                btnBrown.interactable = false;
                btnOrange.interactable = false;
                btnGreen.interactable = false;
                Debug.Log("You are right");
            }
            else
            {
                Debug.Log("You are wrong");

            }
        }
    }
    public void checkCarColorBrown()
    {
        if (instantiated != null)
        {
            if (sr.color == brown)
            {
                scoreCounterBrown++;
                btnBrownScore.text = scoreCounterBrown.ToString();
                btnBrown.interactable = false;
                btnOrange.interactable = false;
                btnGreen.interactable = false;

                Debug.Log("You are right");
               
            }
            else
            {
                Debug.Log("You are wrong");

            }
        }
    }
    public void checkCarColorGreen()
    {
        if (instantiated != null)
        {
            if (sr.color == green)
            {
                scoreCounterGreen++;
                btnGreenScore.text = scoreCounterGreen.ToString();
                btnBrown.interactable = false;
                btnOrange.interactable = false;
                btnGreen.interactable = false;
                Debug.Log("You are right");
            }
            else
            {
                Debug.Log("You are wrong");

            }
        }
    }
    private void SetRandomColor()
    {

        ran = UnityEngine.Random.Range(0, 5);
        switch (ran)
        {
            case 0:
                  
                currentColor = "Orange";
                sr.color = orange;
                break;
            case 1:
                currentColor = "Green";
                sr.color = green;
                break;
            case 2:
                currentColor = "Brown";
                sr.color = brown;
                break;
            case 4:

                currentColor = "Orange";
                sr.color = orange;
                break;
            case 5:
                currentColor = "Green";
                sr.color = green;
                break;
            case 3:
                currentColor = "Brown";
                sr.color = brown;
                break;


        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag.Equals("car"))
        {

            Destroy(collision.gameObject);
            
            
            instantiated =  Instantiate(car, new Vector2(6.29f, -3.07f), transform.rotation);
            sr = instantiated.GetComponent<SpriteRenderer>();
            SetRandomColor();
            btnOrange.interactable = true;
            btnGreen.interactable = true;
            btnBrown.interactable = true;

        }
    }
}
