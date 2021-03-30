using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    public int hitpoints = 9999;
    public Animator dummy_animator;

    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        hitpoints -= damage;
        dummy_animator.SetTrigger("Hit");
        if (hitpoints <= 0)
        {
            hitpoints = 9999;

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
