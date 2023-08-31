using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [Header("Components")]
    
    public Transform[] spawnPoints;
    public GameObject[] dusman;
    

    [Header("Gameplay")]
    public float interval;
    void Start()
    {
        InvokeRepeating("spawn", 0.5f, interval);
        
    }

    private void Update()
    {
        
    }
    private void spawn()
    {
        int randPos = Random.Range(0, spawnPoints.Length);
        int ras = Random.Range(0,dusman.Length);
        
        GameObject newEnemy = Instantiate(dusman[ras], spawnPoints[randPos].position, Quaternion.identity);
    }

     
}
