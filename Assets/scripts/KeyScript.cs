using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public bool isCollected;
    public GameObject self;
    public GameObject player;
    public Animator animator;

    public GameObject music;
    public GameObject musicManager;
    public GameObject blackScreen;

    public bool isFive = false;

    private void Update()
    {
        self.GetComponent<Transform>().Rotate(0, 0, 50 * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!isCollected)
        {
            isCollected = true;

            music.GetComponent<AudioSource>().Play();
            musicManager.GetComponent<AudioSource>().volume = 0;

            animator.SetBool("isCollected", true);

            if (isFive == false)
            {
                player.GetComponent<movement>().enabled = false;
                player.GetComponent<Rigidbody2D>().gravityScale = 0;
            }
            Invoke("turnOff", 5f);
        }
    }

    public void turnOff()
    {
        self.SetActive(false);

        if (isFive == false)
        {
            blackScreen.GetComponent<endLevel>().BlackScreen();
        }
        else
        {
            return;
        }
    }



}
