using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycard : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPlayer;
    public int keycards = 0;
    void Start()
    {
        keycards = myPlayer.GetComponent<PlayerMovement>().cards;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if(player.gameObject.CompareTag("Player"))
        {
            keycards++;
            myPlayer.GetComponent<PlayerMovement>().cards = keycards;
            Destroy(gameObject);
        }
    }
}
