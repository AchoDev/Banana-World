using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockSpecial : MonoBehaviour
{

    private Animator animator;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }
    private void Update()
    {
        if(animator.GetBool("isCollected") == true)
        {
            PlayerPrefs.SetInt("mask01Collected", 1);
        }
    }
}
