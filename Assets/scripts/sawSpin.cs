using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawSpin : MonoBehaviour
{

    public Transform self;
    public float sawSpeed = 100f;
    public GameObject player;
    public GameObject key;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        self.Rotate(0, 0, -50 * Time.deltaTime * sawSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!key.GetComponent<KeyScript>().isCollected)
        {
            player.GetComponent<movement>().die();
        }
        
    }

}
