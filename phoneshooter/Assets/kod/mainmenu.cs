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
    public void lvlgec�s() 
    {

        SceneManager.LoadScene("Start");
    
    }
    public void ex�t() 
    {


        Application.Quit();
    
    }
}

