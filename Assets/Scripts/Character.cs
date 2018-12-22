using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float moveSpeed = 8f;
    public Joystick joystick;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (Vector3.right * Time.deltaTime); 
        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.up * joystick.Vertical);    
        if (moveVector != Vector3.zero)
        {
            transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
        }
    }
}