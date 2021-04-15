using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;
    public float movespeed = 5f;
    private Rigidbody2D rb, playerRB;
    private Vector2 movement;
    private Vector2 direction;
    public Animator enemyAnimator;
    public int damage = 10;
    public int hitpoints = 100;

    private Vector2 moving;
    private float moveX;
    private float moveY;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        direction = player.transform.position - transform.position;
        direction.Normalize();

        movement = direction;
        moveX = direction.x;
        moveY = direction.y;
        enemyAnimator.SetFloat("Horizontal", moveX);
        enemyAnimator.SetFloat("Vertical", moveY);
        if ((moveX == 1) || (moveX == -1) || (moveY == 1) || (moveY == -1))
        {
            enemyAnimator.SetFloat("lastX", moveX);
            enemyAnimator.SetFloat("lastY", moveY);
        }
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction) 
    {
        rb.MovePosition((Vector2)transform.position + (direction * movespeed * Time.deltaTime));
    }

    public void TakeDamage(int damage)
    {
        hitpoints -= damage;
        //dummy_animator.SetTrigger("Hit");
        if (hitpoints <= 0)
        {
            Dead();

        }
    }
    void Dead()
    {
        Destroy(gameObject);
    }

}
