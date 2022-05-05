using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monkeRun : StateMachineBehaviour
{
    private Rigidbody2D rb;
    private Transform transform;
    public float speed;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb = animator.GetComponent<Rigidbody2D>();
        transform = animator.GetComponent<Transform>();

    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        Vector2 newPos = new Vector2(speed, -5);
        rb.MovePosition((Vector2)transform.position + newPos * Time.fixedDeltaTime);
    }
}
