using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNodeGoalDesk : Behaviour
{
    public Blackboard Blackboard;
    private Transform[] DeskSpots;
    private bool patrolling;
    public int spot;
    public GameObject guard;

    public override void onInitialize()
    {
        base.onInitialize();
        DeskSpots = Blackboard.spotsDesk;
        patrolling = true;
    }


    public override Status update()
    {
        while (true)
        {


            if (patrolling == true)
            {
                float min = 65000;
                for (int i = 0; i < DeskSpots.Length; i++)
                {
                    if (Vector3.Distance(DeskSpots[i].position, guard.transform.position) < min)
                    {
                        min = Vector3.Distance(DeskSpots[i].position, guard.transform.position);
                        spot = i;
                    }

                }

                patrolling = false;
                Blackboard.targetgoalNode = spot;

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
