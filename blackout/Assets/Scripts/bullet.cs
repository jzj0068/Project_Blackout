using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 100;
    //public distance = 50;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

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

        Destroy(gameObject);

    }
}
