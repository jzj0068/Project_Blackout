using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingY : MonoBehaviour
{
    public float frequency = 1f;
    public float amplitude = 0.5f;
    Vector2 pos = new Vector2();
    Vector2 tempPos = new Vector2();
  
    

    void Start()
    {

        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = pos;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
}
