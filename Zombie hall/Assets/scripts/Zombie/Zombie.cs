using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    [SerializeField] private int health;
    [SerializeField] private Transform castPoint;
    [SerializeField] private float fovdistance;
    public Blackboard blackboard;
    public LayerMask ActionMask;
    public LayerMask ZombieMask;
    public LayerMask ObstacleMask;
    
    // Start is called before the first frame update
    void Start()
    {
       
        health = 100;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if(CanSeePlayer(fovdistance))
        {
            blackboard.playerseen = true;
        }
        else
        {
            blackboard.playerseen = false;
        }


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
            health = health - 20;
        if (health <= 0)
            Destroy(gameObject);
        
    }

    private bool CanSeePlayer(float distance)
    {


        bool val = false;
        float castDist = distance;
        Vector2 endPos = castPoint.position + Vector3.right * castDist;

        RaycastHit2D hit = Physics2D.Linecast(castPoint.position, endPos,ActionMask);
        

        if (hit.collider!=null)
        {
            if (hit.collider.gameObject.CompareTag("Player")) 
            {
                val = true;
                Debug.DrawLine(castPoint.position, hit.point, Color.red);
            }
            else
            {
                val = false;

                Debug.DrawLine(castPoint.position, endPos, Color.blue);
            }
               
        }
        else
        {
            Debug.DrawLine(castPoint.position, endPos, Color.blue);
        }


        //Debug.Log(val);
        return val;
    }
}
