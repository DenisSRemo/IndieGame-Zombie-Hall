using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenade_trap_script : MonoBehaviour
{

    public float Damage = 100;
    public float BlastRadius = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // the damage of the granade is based on the distance between the grenade trap and zombie
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
                    var damagePercent = Mathf.InverseLerp(BlastRadius, 0, distance);
                    enemy.TakeHit(damagePercent * Damage);
                }
            }
        }
        
    }

//expoldes on contact with a zombie
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Zombie")
        {
            FindObjectOfType<AudioManager>().Play("grenade");
            Explode();
            Destroy(gameObject);
        }
       
    }
            

}
