using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{

    Transform target;
    Vector3 direction;
    private float velocity;
    public float speed = 4f; // 구체 속도
    public float deathtime = 5f; // 생존 시간
    public float damage = 1f; // 데미지
    public LayerMask playerLayer;
    private bool isColliding;
    private float radius;

    void Start()
    {
        radius = GetComponent<CircleCollider2D>().radius;
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
        Destroy(this.gameObject, deathtime);

        isColliding = Physics.OverlapSphere(transform.position, radius * 0.5f, playerLayer).Length > 0;

        if (isColliding)
        {
            Destroy(this.gameObject);
        }
    }
}