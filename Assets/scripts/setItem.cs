using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setItem : MonoBehaviour
{

    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            player.GetComponent<movement>().jumpsCount = 3;   
        }
    }
}
