﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //print("collided");
        if (collision.gameObject.tag == "Projectile" || collision.gameObject.tag == "Fireball")
        {
            print("WINNER!");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}