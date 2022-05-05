using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject shootPos;

    public int ammo = 15;
    public int reloadTime = 5;
    private int reloadSave;
    private int ammoSave;
    private bool isReloading = false;

    private Animator animator;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
        reloadSave = reloadTime;
        ammoSave = ammo;
    }
    public void shoot()
    {
        if (ammo > 1)
        {
            Instantiate(bullet, shootPos.GetComponent<Transform>());
            ammo--;
        }
        else
        {
            
            StartCoroutine("coroutine");
            isReloading = true;
        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(ammo > 1)
        {
            animator.SetBool("isInRange", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            animator.SetBool("isInRange", false);
        }
        
        
    }

    IEnumerator coroutine()
    {
        if(isReloading == false)
        {

            
            animator.SetBool("isInRange", false);

            while (reloadTime > -1)
            {
                yield return new WaitForSeconds(1);
                reloadTime--;
            }

            ammo = ammoSave;
            reloadTime = reloadSave;
        }

        isReloading = false;

        
    }

}
