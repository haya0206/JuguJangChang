using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public float spawnTime = 0.2f;
    float preTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > preTime + spawnTime){
            
            preTime = Time.time;
        }
    }
}
