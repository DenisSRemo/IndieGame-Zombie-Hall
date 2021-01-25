using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
   
    public GameObject gameObject;
   
    void Start()
    {
        rb.velocity = transform.right * speed;
        
        
    }

    void Update()
    {
       
            Destroy(gameObject,1);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Zombie")
            Destroy(gameObject);
        if (collision.tag == "Zombie2")
            Destroy(gameObject);
    }
}
