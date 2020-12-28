using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeScript : MonoBehaviour
{


    public float Speed;
    
   
    public Rigidbody2D rb;
    public float Damage = 100;
    public float BlastRadius=1;



    void Start()
    {
        
        rb.velocity = transform.right * Speed;
        
        

        Destroy(gameObject, 3);
    }

   
    void Update()
    {
       
    }


    void Explsion()
    {

        if (BlastRadius > 0)
        {
           var hitColliders= Physics2D.OverlapCircleAll(transform.position, BlastRadius);
            foreach(var hitCollider in hitColliders)
            {
                var enemy = hitCollider.GetComponent<Zombie>();
                if(enemy)
                {
                    
                }
            }
        }
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(BlastRadius>0)
        {
            Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, BlastRadius);
            foreach (Collider2D hitCollider in hitColliders)
            {
                var enemy = hitCollider.GetComponent<Zombie>();
                if (enemy)
                {
                  //var closestPosition=  hitCollider.
                }
            }
        }
        else
        {
            var enemy = collision.collider.GetComponent<Zombie>();
            if (enemy)
            {
                enemy.TakeHit(50);
            }
        }
    }



}
