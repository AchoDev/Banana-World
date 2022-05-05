using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 20f;
    public float moveDistance = 30f;
    public AudioSource akShotSound;
    private GameObject player;

    private Vector2 startPos;





    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        startPos = this.GetComponent<Transform>().position;

        rb.velocity = Vector2.left * speed;
        if (akShotSound == null) 
        {
            return;          
        }
        else
        {
            akShotSound.Play();
        }
        
    }

    void Update()
    {
        Vector2 currentPos = transform.position;
        if(currentPos.x < startPos.x - moveDistance || currentPos.x > startPos.x + moveDistance) 
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "monke" || collision.tag == "item")
        {
            return;
        }
        else if (collision.tag == "Player")
        {
            player.GetComponent<movement>().die();
            Destroy(gameObject);
        }
    
    }
}
