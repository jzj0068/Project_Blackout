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

    public int hitpoints = 100;

    public Rigidbody2D rb;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
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
