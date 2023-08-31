using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public GameObject bullet;
    private Vector3 bulletpoint;
    public AudioSource ates;

    
    void Start()
    {

        
      
      
    }

    public void bas() 
    {

        Instantiate(bullet, transform.position, Quaternion.identity);
        
        ates.Play();
        
    }
    public void cýkýs() 
    {

        Application.Quit();
    
    }
    void Update()
    {
        

        
    }
}
