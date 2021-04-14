using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{

    public float kbPower = 100;
    public float kbDuration = 1;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(PlayerMovement.instance.Knockback(kbDuration, kbPower, this.transform));
        }
    }
}
