using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instance;
    public float moveSpeed = 5.0f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator agent_Animator;
    public int cards = 0;
    public float knockback;

    private void Awake()
    {
        instance = this;
    }
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
    public IEnumerator Knockback(float kbDuration, float kbPower, Transform obj)
    {
        float timer = 0;
        while (kbDuration > timer) 
        {
            timer += Time.deltaTime;
            Vector2 kbDirection = (obj.transform.position - this.transform.position).normalized;
            rb.AddForce(-kbDirection * knockback);

        }
        yield return 0;
    }
}
