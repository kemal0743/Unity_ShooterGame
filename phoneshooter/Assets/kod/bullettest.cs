using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bullettest : MonoBehaviour
{
    private GameObject enemyy;
    private Rigidbody2D rb;
    public float force;
    private shaker camon;
    
    

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enemyy = GameObject.FindGameObjectWithTag("Enemy");
        camon = GameObject.FindGameObjectWithTag("Screenshake").GetComponent<shaker>();
     
        if(enemyy == null) 
        {


            Destroy(gameObject, 0f);

        }
        else 
        {
            Vector3 direction = enemyy.transform.position - transform.position;
            rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
            float rot = Mathf.Atan2(-direction.x, -direction.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rot + 90);
        }

        //Vector3 direction = enemyy.transform.position - transform.position;
        //rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        //float rot = Mathf.Atan2(-direction.x, -direction.y) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 4f);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy") 
        {
            camon.testo();
            Destroy(gameObject, 0f);
            scorescript.scorevalue += 10;
            
            
        }
    }
}
