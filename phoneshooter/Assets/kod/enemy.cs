using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float Healts;
    [Header("Target")]
    private Transform playerPos;
    public GameObject efect;
    
    

    [Header("Gameplay")]
    public float speed;
    
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 10f);
       if(Healts <= 0) 
        {


            Destroy(gameObject, 0f);
            
            
        
        }
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);

    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "bullet") 
        {

            Healts--;
            Instantiate(efect, transform.position, Quaternion.identity);

        }
    }
    
}
