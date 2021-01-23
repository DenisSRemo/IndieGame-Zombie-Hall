﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instakill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Zombie")
        {
            var enemy = collision.GetComponent<Zombie>();
            enemy.TakeHit(100);
        }
        if (collision.tag == "Zombie2")
        {
            var enemy = collision.GetComponent<Zombie2>();
            enemy.TakeHit(100);
        }
    }
}
