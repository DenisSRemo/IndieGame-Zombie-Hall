using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoNodeGoalFiles : Behaviour
{
    public Blackboard Blackboard;
    public NavMeshAgent agent;
    private Transform[] FilesSpots;
    public int spot;
    public GameObject guard;

    public override void onInitialize()
    {
        base.onInitialize();
        agent.GetComponent<NavMeshAgent>();
        FilesSpots = Blackboard.spotsFiles;
        spot = Blackboard.targetgoalNode;
    }

    public override Status update()
    {
        while (true)
        {
            agent.destination = FilesSpots[spot].position;
            if (Vector3.Distance(guard.transform.position, FilesSpots[spot].position) < 5f)
            {

                if (spot == FilesSpots.Length - 1)
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
