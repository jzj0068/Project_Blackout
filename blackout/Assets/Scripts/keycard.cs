using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if(player.gameObject.CompareTag("Player"))
        {
            player.GetComponent<PlayerMovement>();
            Destroy(gameObject);
        }
    }
}
