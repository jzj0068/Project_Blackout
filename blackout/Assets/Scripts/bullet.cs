using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 50;

    private int destroyTime = 5;
    //public distance = 50;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, destroyTime);
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.CompareTag("Dummy"))
        {
            hitInfo.GetComponent<Dummy>().TakeDamage(damage);
        }
        else if (hitInfo.gameObject.CompareTag("enemy"))
        {
            hitInfo.GetComponent<EnemyMovement>().TakeDamage(damage);
        }
        else if (hitInfo.gameObject.CompareTag("EnemyFollow"))
        {
            hitInfo.GetComponent<EnemyFollow>().TakeDamage(damage);
        }

        Destroy(gameObject);

    }
}
