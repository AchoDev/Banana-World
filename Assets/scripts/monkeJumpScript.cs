using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monkeJumpScript : MonoBehaviour
{

    public GameObject monke;
    public float x;
    public float y;
    private bool isJumped = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "monke" && isJumped != true)
        {
            isJumped = true;
            monke.GetComponent<bigMonkeScript>().jump();
            this.gameObject.SetActive(false);
        }
    }

    public void jump() 
    {
        Vector2 jumpDirection = new Vector2(x, y);
        monke.GetComponent<Rigidbody2D>().AddForce(jumpDirection);
    }
}

