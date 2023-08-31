using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shaker : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
       
    }
    public void testo()
    {


        anim.SetTrigger("snake");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
