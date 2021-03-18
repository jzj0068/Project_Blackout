using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    public Animator animator;
    


    // Update is called once per frame
    void Update()
    {

       

        
         animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
         //animator2.SetFloat("Vertical", Input.GetAxis("Vertical"));


        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 
            Input.GetAxis("Vertical"), 0.0f);

        transform.position = transform.position + movement * Time.deltaTime * speed;
        

    }
}
