using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void lvlgecýs() 
    {

        SceneManager.LoadScene("Start");
    
    }
    public void exýt() 
    {


        Application.Quit();
    
    }
}

