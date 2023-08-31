using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter_ontrol : MonoBehaviour
{
    float Vertical, horizontal;
    public AudioSource ses;
    public float health;
    
    public int speed;
    

    public Joystick jy;


    private void FixedUpdate()
    {
        Vertical = jy.Vertical;
        horizontal = jy.Horizontal;
        if(Vertical!=0 || horizontal != 0) 
        {
            //transform.up = new Vector3(horizontal * speed, Vertical * speed, 0); araba haraketinde kullanýlýr

            transform.Translate(new Vector3(horizontal*speed, Vertical*speed, 0 )* speed * Time.deltaTime,Space.World);
            
        }
        
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy") 
        {

            health -= 10f;
        
        }

       // if(collision.tag == "Can") 
       // {

            //health += 10f;
            //Debug.Log("tm");
        
       // }
    }
}
