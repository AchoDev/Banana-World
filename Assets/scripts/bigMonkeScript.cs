using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigMonkeScript : MonoBehaviour
{

    public float speed = 20f;
    public GameObject player;
    public Animator Animator;
    public float force = 20f;

    // private Rigidbody2D rb = this.GetComponent<Rigidbody2D>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.GetComponent<movement>().die();
        }
        
    }

    public void jump()
    {
        Animator.SetBool("needsToJump",true);
        Debug.Log("jump()");
    }
    public void jumpEvent()
    {
        Animator.SetBool("needsToJump", false);
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(force, force);
        Debug.Log("test 1");
    }

}
