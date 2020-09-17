using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject car;
    public GameObject destroy;
   

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
            
           
        }
    }
}
