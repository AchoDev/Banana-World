using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeKill : MonoBehaviour
{
    public GameObject player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            player.GetComponent<movement>().die();
        }
    }

}
