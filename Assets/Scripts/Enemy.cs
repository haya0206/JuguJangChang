using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Transform target;
    Vector3 direction;
    public GameObject gameManager;
    private float velocity;
    public float speed = 4f; // 구체 속도
    public float damage = 1f; // 데미지

    void Start()
    {
        
    }
    void Update()
    {
        target = GameObject.FindWithTag("Player").transform;
        direction = (target.position - transform.position).normalized;
        velocity = speed * Time.deltaTime;
        float distance = Vector3.Distance(target.position, transform.position);
        this.transform.position = new Vector3(transform.position.x + (direction.x * velocity),
                                                   transform.position.y + (direction.y * velocity),
                                                     transform.position.z + (direction.z * velocity));

    }
     void OnTriggerEnter2D(Collider2D other)
     {      
         if (other.gameObject.tag == "Player")
         {
            Time.timeScale = 0.0f;
            Debug.Log("사망");
         }
 
         if (other.gameObject.tag == "Weapon")
         {
             PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score", 0) + 10);
             Debug.Log(PlayerPrefs.GetInt("Score", 0));
             Destroy(this.gameObject);
         }
     }
}