using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoNoadGoalDesk : Behaviour
{
    public Blackboard Blackboard;
    public NavMeshAgent agent;
    private Transform[] DeskSpots;
    public int spot;
    public GameObject guard;

    public override void onInitialize()
    {
        base.onInitialize();
        agent.GetComponent<NavMeshAgent>();
        DeskSpots = Blackboard.spotsDesk;
        spot = Blackboard.targetgoalNode;
    }

    public override Status update()
    {
        while (true)
        {
            agent.destination = DeskSpots[spot].position;
            if (Vector3.Distance(guard.transform.position, DeskSpots[spot].position) < 5f)
            {

                if (spot == DeskSpots.Length - 1)
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
