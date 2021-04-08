using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardread : MonoBehaviour
{
    public GameObject myPlayer;
    public GameObject transitionDoor;
    public bool haveCard = false;
    public bool triggerCard;
    public Animator console;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (haveCard == true)
        {
            transitionDoor.GetComponent<Collider2D>().isTrigger = true;
        }
    }
    void OnTriggerEnter2D(Collider2D cardholder)
    {
        if(myPlayer.GetComponent<PlayerMovement>().cards == 1)
        {
            haveCard = true;
            console.SetTrigger("haveCard");
        }
    }
}
