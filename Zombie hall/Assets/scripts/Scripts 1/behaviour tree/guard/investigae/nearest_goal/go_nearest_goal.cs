using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class go_nearest_goal : Behaviour
{
    public Blackboard Blackboard;
    public NavMeshAgent agent;
    private Transform[] neargoalSpots;
    public int spot;
    public GameObject guard;

    public override void onInitialize()
    {
        base.onInitialize();
        agent.GetComponent<NavMeshAgent>();
        neargoalSpots = Blackboard.ObjectiveSpots;
        spot = Blackboard.targetneargoalNode;
    }

    public override Status update()
    {
        while (true)
        {


            agent.destination = neargoalSpots[spot].position;

            if (Vector3.Distance(guard.transform.position, neargoalSpots[spot].position) <= 6f)
            {
                Blackboard.investigate_door = false;
                return Status.Success;
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
