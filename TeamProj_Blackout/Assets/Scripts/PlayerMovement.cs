using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    public float bulletSpeed = 1.0f;

   

    public GameObject bulletPrefab;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player 
            GameObject bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, 0.0f);
            Destroy(bullet, 2.0f);

        }

    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
