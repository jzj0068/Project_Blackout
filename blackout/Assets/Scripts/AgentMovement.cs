using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator agent_Animator;
    public int keycard = 0;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        agent_Animator.SetFloat("Horizontal", movement.x);
        agent_Animator.SetFloat("Vertical", movement.y);
        agent_Animator.SetFloat("speed", movement.sqrMagnitude);
        if ((movement.x == 1) || (movement.x == -1) || (movement.y == 1) || (movement.y == -1))
        {
            agent_Animator.SetFloat("lastX", movement.x);
            agent_Animator.SetFloat("lastY", movement.y);
        }


    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}
