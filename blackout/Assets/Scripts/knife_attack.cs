using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife_attack : MonoBehaviour
{
    public Animator knife_ani;
    public int damage = 3;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            knife_ani.SetTrigger("Strike");
        }
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if ((hitInfo.gameObject.CompareTag("Dummy")))
        {
            hitInfo.GetComponent<Dummy>().TakeDamage(damage);
            
        }

    }
}
