using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollect : MonoBehaviour
{

    public GameObject self;
    public Transform selfT;

    private bool isCollected = false;

    public GameObject player;

    public float jumpsPlus = 3f;

    // Update is called once per frame
    void Update()
    {
        selfT.Rotate(0, 0, 50 * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isCollected == false)
        {
            isCollected = true;
            self.SetActive(false);
            player.GetComponent<movement>().jumpsCount += jumpsPlus;
        }
    }
}
