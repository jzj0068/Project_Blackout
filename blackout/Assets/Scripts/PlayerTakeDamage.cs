using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamage : MonoBehaviour
{
    public int damage = 25;
    public GameObject myPlayer;
    public void OnCollisionEnter2D(Collision2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "Player")
        {
            myPlayer.GetComponent<PlayerMovement>().TakeDamage(damage);

        }
    }
}
