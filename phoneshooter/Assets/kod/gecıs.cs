using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gecıs : MonoBehaviour
{
    public AudioClip ses;
    public AudioSource ses2;
    void Start()
    {
        ses2.Play();
        
    }

    public void startlvl() 
    {

        SceneManager.LoadScene("Start");
    
    }
    public void exıt() 
    {

        Application.Quit();
    
    }
    public void sustur() 
    {

        ses2.Stop();
    
    }
    
    
}
