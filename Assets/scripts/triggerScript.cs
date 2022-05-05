using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    public GameObject piston;
    public GameObject player;
    public GameObject pistonTop;

    public bool startPush;

    public float pistonPushX;
    public float pistonPushY;
    public float waitBeforeLaunch = 1f;

    public float pistonForce = 500f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerSingle" && !startPush)
        {
            startPush = true;
            StartCoroutine("coroutine");
        }
        
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "PlayerSingle")
        {
            startPush = false;
            piston.GetComponent<Animator>().SetBool("isStandingOnTop", false);
        }
    }
        

    IEnumerator coroutine()
    {
        yield return new WaitForSeconds(waitBeforeLaunch);

        if(startPush)
        {
            piston.GetComponent<Animator>().SetBool("isStandingOnTop", true);
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(pistonPushX * pistonForce, pistonPushY * pistonForce));
        }
        

    }

}
