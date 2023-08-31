using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scorescript : MonoBehaviour
{
    Text score;
    public static int scorevalue = 0;
    
   
    
    
    
    void Start()
    {
        score = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ""+ scorevalue;
       
        if(scorevalue == 30) 
        {

            SceneManager.LoadScene("Start2");
        
        }
    }
   
}
