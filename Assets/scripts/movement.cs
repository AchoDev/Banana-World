using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class movement : MonoBehaviour
{
    public float speed = 6f;
    public float jumpForce = 10f;
    public float spinForce = 100f;
    public float walkSpinForce = 10f;
    public float jumpsCount = 3;

    public GameObject uB;
    public bool goLeft;
    public bool goRight = true;

    public bool isDead = false;

    private Vector2 move;
    private Vector2 jump;

    public Rigidbody2D rb;
    public GameObject deathParticle;
    public GameObject self;
    public GameObject loosingSound;
    public GameObject bgMusic;

    public Joystick joystick;

    // Update is called once per frame
    void Update()
    {

        //  || joystick.Horizontal > 0.1
        //   || joystick.Horizontal < -0.1

        if (Input.GetKey("d") || goRight)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y + Time.deltaTime);
            rb.AddTorque(-rb.velocity.x * walkSpinForce * Time.deltaTime, ForceMode2D.Force);
        }
        else if (Input.GetKey("a") || goLeft)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y + Time.deltaTime);
            rb.AddTorque(-rb.velocity.x * walkSpinForce * Time.deltaTime, ForceMode2D.Force);
        }
        if (Input.GetKeyDown("space"))
        {
            jumpBanana();
        }
        //if (isMobile == true && joystick.Horizontal > 0.9);
        //{
        //  rb.velocity = new Vector2(speed * joystick.Horizontal, rb.velocity.y + Time.deltaTime);
        //  rb.AddTorque(joystick.Horizontal * 2 * walkSpinForce * Time.deltaTime, ForceMode2D.Force);
        //}

    
    }

    public void right(bool isDown)
    {
        if (isDown)
        {
            goRight = true;
        }
        else
        {
            goRight = false;
        }
    }
    public void left(bool isDown)
    {
        if (isDown)
        {
            goLeft = true;
        }
        else
        {
            goLeft = false;
        }
    }
    
    public void jumpBanana()
    {
        if (jumpsCount > 0 || uB.GetComponent<itemCollect_ub>().isUnlimited == true)
        {
            if (uB.GetComponent<itemCollect_ub>().isUnlimited == false)
            {
                jumpsCount -= 1;
            }
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            rb.AddTorque(-rb.velocity.x * spinForce * Time.deltaTime);
        }
    }
        
  
    
    

    public void die()
    {
        self.SetActive(false);
        deathParticle.GetComponent<Transform>().position = new Vector2(self.GetComponent<Transform>().position.x, self.GetComponent<Transform>().position.y);
        deathParticle.GetComponent<ParticleSystem>().Play();
        loosingSound.GetComponent<AudioSource>().Play();
        bgMusic.GetComponent<AudioSource>().volume = 0f;
    }

}