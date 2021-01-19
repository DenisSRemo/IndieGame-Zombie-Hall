using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoNodeGoalComputer : Behaviour
{
    public Blackboard Blackboard;
    public NavMeshAgent agent;
    private Transform[] ComputerSpots;
    public int spot;
    public GameObject guard;

    public override void onInitialize()
    {
        base.onInitialize();
        agent.GetComponent<NavMeshAgent>();
        ComputerSpots = Blackboard.spotsComputer;
        spot = Blackboard.targetgoalNode;
    }

    public override Status update()
    {
        while (true)
        {
            agent.destination = ComputerSpots[spot].position;
            if (Vector3.Distance(guard.transform.position, ComputerSpots[spot].position) < 5f)
            {

                if (spot == ComputerSpots.Length - 1)
                {


                    spot = 0;
                    return Status.Success;
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
