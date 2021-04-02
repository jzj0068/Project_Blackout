using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife_attack : MonoBehaviour
{
    public Animator knife_ani;

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
}
