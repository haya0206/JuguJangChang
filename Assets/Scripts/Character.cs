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
        PlayerPrefs.SetInt("Score",0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.up * joystick.Vertical);    
        transform.Rotate(Vector3.back , 20 * speed * Time.deltaTime);
        if (moveVector != Vector3.zero)
        {
            transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
        }
    }
}