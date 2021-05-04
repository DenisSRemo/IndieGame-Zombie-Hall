using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeScript : MonoBehaviour
{


    public float Speed;

    public float timeToExplde=3;
    public float timeOfThrow;
    public Rigidbody2D rb;
    public float Damage = 400;
    public float BlastRadius=5;



    void Start()
    {
        timeOfThrow = Time.time;
        rb.velocity = transform.right * Speed;
        
        

       
    }

   
    void Update()
    {
       if(Time.time-timeOfThrow>=timeToExplde)
        {
            Explode();
            Destroy(gameObject);
           
        }
    }

    // the damage of the granade is based on the distance between the grenade and zombie
    void Explode()
    {
        if (BlastRadius > 0)
        {
            Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, BlastRadius);
            foreach (Collider2D hitCollider in hitColliders)
            {
                var enemy = hitCollider.GetComponent<Zombie>();
                if (enemy)
                {
                    var closestPosition = hitCollider.ClosestPoint(transform.position);
                    var distance = Vector3.Distance(closestPosition, transform.position);
                    var damagePercent = Mathf.InverseLerp(1/10,BlastRadius, distance);
                    enemy.TakeHit(damagePercent * Damage*4);
                }
            }
        }
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        
    }



}
