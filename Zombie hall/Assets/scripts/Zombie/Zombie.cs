using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
   
    [SerializeField]private int health;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
        health = 100;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
            health = health - 20;
        if (health <= 0)
            Destroy(gameObject);
        
    }
}
