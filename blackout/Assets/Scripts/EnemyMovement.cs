using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float accelerationTime = 1f;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;
    public int damage = 10;
    public Animator enemyAnimator;
    public int hitpoints = 100;
    private float range1; 
    private float range2;
    public Rigidbody2D rb;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            range1 = Random.Range(-1f, 1f);
            range2 = Random.Range(-1f, 1f);
            movement = new Vector2(range1, range2);
            timeLeft += accelerationTime;
            enemyAnimator.SetFloat("Horizontal", range1);
            enemyAnimator.SetFloat("Vertical", range2);
        }
        if ((range1 == 1) || (range1 == -1) || (range2 == 1) || (range2 == -1))
        {
            enemyAnimator.SetFloat("lastX", movement.x);
            enemyAnimator.SetFloat("lastY", movement.y);
        }

    }

    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
    }

    public void TakeDamage(int damage)
    {
        hitpoints -= damage;
        //dummy_animator.SetTrigger("Hit");
        if (hitpoints <= 0)
        {
            Destroy(gameObject);

        }
    }
}
