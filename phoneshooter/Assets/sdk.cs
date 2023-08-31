using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sdk : MonoBehaviour
{
    public spawner sps;
    void Start()
    {
        sps = gameObject.AddComponent<spawner>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
