using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class patrol : MonoBehaviour
{
    public float speed;
    public Transform[] moveSpots;
    public int Spot=0;
    
   public  NavMeshAgent agent;
    private int j;
    private bool patrolling;
    private bool initial_patrolling;
    public Blackboard blackboard;
    public Transform[] Objectives; 
    private int spot;

    void Start()
    {
        patrolling = true;
        initial_patrolling = false;


        agent = GetComponent<NavMeshAgent>();
        
        
        moveSpots = blackboard.moveSpots;
    }

   
    void Update()
    {
        if (patrolling == true)
        {
            float min = 65000;
            for (int i = 0; i < moveSpots.Length; i++)
            {
                if (Vector3.Distance(moveSpots[i].position, transform.position) < min)
                {
                    min = Vector3.Distance(moveSpots[i].position, transform.position);
                    Spot = i;
                }
            }

            initial_patrolling = true;
            patrolling = false;
        }
        if(initial_patrolling==true)
            Patrolling(Spot);
    }



    void Patrolling(int spot)
    {
        agent.destination = moveSpots[Spot].position;
      
        if (Vector3.Distance(transform.position, moveSpots[Spot].position) < 6f)
        {
            if (Spot == moveSpots.Length - 1)
                Spot = 0;
            else
            {
                Spot++;
            }
        }
    }


    void Chase()
    {
        agent.destination=blackboard.spyPosition;
    }


    void investigate_door()
    {

        float min = 65000;

        for (int i = 0; i < Objectives.Length; i++)
        {
            if (Vector3.Distance(transform.position, Objectives[i].position) < min)
            {
                min = Vector3.Distance(transform.position, Objectives[i].position);
                spot = i;
            }
        }

        agent.destination = Objectives[spot].position;

    }

    void invetigate_source_noise()
    {
        agent.destination = blackboard.LastKnownPosition;
    }
}

