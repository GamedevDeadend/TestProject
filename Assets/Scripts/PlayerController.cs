using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            rigidbody2d.velocity = new Vector2(speed*Time.deltaTime, 0f);
        }
        
        else if(Input.GetAxis("Horizontal") < 0)
        {
            rigidbody2d.velocity = new Vector2(-speed*Time.deltaTime, 0f);
        }

        else if(Input.GetAxis("Vertical") > 0)
        {
            rigidbody2d.velocity = new Vector2(0,speed*Time.deltaTime);
        }

        else if(Input.GetAxis("Vertical") < 0)
        {
            rigidbody2d.velocity = new Vector2(0,-speed*Time.deltaTime);
        }

        else if (Input.GetAxis("Horizontal") == 0f && Input.GetAxis("Vertical") == 0)
        {
            rigidbody2d.velocity = new Vector2(0f, 0f);
        }

    }
}