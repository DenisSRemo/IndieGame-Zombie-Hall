using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class goNode : Behaviour
{
    public Blackboard Blackboard;
    public NavMeshAgent agent;
    private Transform[] PatrolSpots;
    public int spot;
    public GameObject guard;

    public override void onInitialize()
    {
        base.onInitialize();
        agent.GetComponent<NavMeshAgent>();
        PatrolSpots = Blackboard.moveSpots;
        spot = Blackboard.targetNode;
    }

    public override Status update()
    {
        while (true)
        {
            agent.destination = PatrolSpots[spot].position;
            if (Vector3.Distance(guard.transform.position, PatrolSpots[spot].position) < 5f)
            {
                
                if (spot == PatrolSpots.Length - 1)
                {


                    spot = 0;

                }
                else
                {
                    spot++;
                }



            }

            return Status.Running;
        }

        return base.update();


    }

    public override void onTerminate(Status status)
    {
        base.onTerminate(status);
    }
}
