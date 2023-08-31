using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman : MonoBehaviour
{
    public float Healts;
    private Transform playerPozz;
    public float speed;
    public GameObject efect;
    void Start()
    {
        playerPozz = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Healts <= 0) 
        {

            Destroy(gameObject, 0f);
           
        
        }

        transform.position = Vector2.MoveTowards(transform.position, playerPozz.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "bullet") 
        {
            Instantiate(efect, transform.position, Quaternion.identity);
            
            Healts--;
        
        }
    }
}
