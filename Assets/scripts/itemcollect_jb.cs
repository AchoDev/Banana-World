using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class itemcollect_jb : MonoBehaviour
{
    public GameObject self;
    public Transform selfT;

    private bool isCollected = false;
    public float counter = 10;

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        selfT.Rotate(0, 0, 50 * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isCollected == false)
        {
            self.SetActive(false);
            isCollected = true;
            player.GetComponent<movement>().jumpForce *= 1.5f;



            Invoke("stopEffect", counter);
        }
    }

    private void stopEffect()
    {
        player.GetComponent<movement>().jumpForce /= 1.5f;
    }
}
