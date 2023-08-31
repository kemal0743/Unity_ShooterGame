using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class artıhealt : MonoBehaviour
{
    private Vector2 konum;
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player") 
        {

            Destroy(gameObject, 0f);
        
        }
    }
}
