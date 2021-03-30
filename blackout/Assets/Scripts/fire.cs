using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public Animator fireAni;
    public AudioSource gun_shot;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fireAni.SetTrigger("Shoot");
            gun_shot.Play();
        }
    }
}
