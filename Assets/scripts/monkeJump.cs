using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monkeJump : StateMachineBehaviour
{
    private Rigidbody2D rb;
    public float force = 10f;

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("needsToJump",false);
        Debug.Log("testetstest");
    }


}
