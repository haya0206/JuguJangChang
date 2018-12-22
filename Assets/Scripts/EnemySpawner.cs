using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] Obj;
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
            float dist = 0;
            Vector2 random = Random.insideUnitSphere * 10;
            random.x += player.transform.position.x;
            random.y += player.transform.position.y;
            while(true){
                dist = Vector2.Distance(random, player.transform.position);
                if(dist > 3) break;
                random = Random.insideUnitSphere * 10;
                random.x += player.transform.position.x;
                random.y += player.transform.position.y;
            }
            Instantiate(Obj[(int)Random.Range(0, Obj.Length + 0.99f)], random, Quaternion.identity);
            preTime = Time.time;
        }
    }
}
