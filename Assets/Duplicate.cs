using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate : MonoBehaviour
{
    public GameObject car;
    public SpriteRenderer sr;
    public Color pink;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag.Equals("car"))
        {

            Destroy(collision.gameObject);
            Debug.Log("Something");
            sr.color = pink;
            Instantiate(car, new Vector2(6.29f, -3.07f), transform.rotation);

        }
    }
}
