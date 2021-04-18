using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instance;
    public float moveSpeed = 5.0f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator agent_Animator;
    public int cards = 0;
    public float knockback;
    public int hitpoints = 100;
    public int damage = 25;
    private void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        instance = this;
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

    public void TakeDamage(int damage)
    {
        hitpoints -= damage;
        if (hitpoints <= 0)
        {
            Dead();
        }
    }

    void Dead()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
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
