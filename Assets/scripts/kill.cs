using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour { 

    public ParticleSystem particle;
    public Transform playerPos;
    public Transform enemyPos;
    public GameObject player;


// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {


        particle.Play();

        enemyPos.position = new Vector2(playerPos.position.x, playerPos.position.y);

    }
}
