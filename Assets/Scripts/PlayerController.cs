// using System.Collections;
// using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float speed;

    public bool IsOver = false;
    public GameObject GameWonScreen;
    public GameObject GameLostScreen;
    // public float accelaration;


    // Update is called once per frame
    void Update()
    {
        if (IsOver == true)
        {
            return;
        }

        if(Input.GetAxis("Horizontal") > 0)
        {
            // speed = speed + (accelaration*Time.deltaTime);
            rigidbody2d.velocity = new Vector2(speed, 0f);
        }
        
        else if(Input.GetAxis("Horizontal") < 0)
        {
            // speed = speed + (accelaration*Time.deltaTime);
            rigidbody2d.velocity = new Vector2(-speed, 0f);
        }

        else if(Input.GetAxis("Vertical") > 0)
        {
            // speed = speed + (accelaration*Time.deltaTime);
            rigidbody2d.velocity = new Vector2(0,speed);
        }

        else if(Input.GetAxis("Vertical") < 0)
        {
            // speed = speed + (accelaration*Time.deltaTime);
            rigidbody2d.velocity = new Vector2(0,-speed);
        }

        else if (Input.GetAxis("Horizontal") == 0f && Input.GetAxis("Vertical") == 0)
        {
            // speed = speed + (-accelaration*Time.deltaTime);
            rigidbody2d.velocity = new Vector2(0f, 0f);
        }    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Door")
        {
            Debug.Log("Lvl Complete");
            IsOver = true;
            GameWonScreen.SetActive(true);
        }

        else if (other.tag == "Enemy")
        {
            IsOver = true;
            GameLostScreen.SetActive(true);
        }

    }

    public void RestartGame()
    {
        Debug.Log("Lvl Restarted");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
