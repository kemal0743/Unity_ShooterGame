using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject panel;
    public Animation anim;
    public GameObject dusman;
    public Vector2 konum;
    
    void Start()
    {
        anim.Play();
        Invoke("panels", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public  void panels()
    {
        panel.SetActive(true);
        Instantiate(dusman,konum, Quaternion.identity);

    }
}
