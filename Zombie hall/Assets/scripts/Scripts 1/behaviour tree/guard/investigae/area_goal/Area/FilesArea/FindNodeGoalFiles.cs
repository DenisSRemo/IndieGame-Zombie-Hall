using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNodeGoalFiles :Behaviour
{
    public Blackboard Blackboard;
    private Transform[] FilesSpots;
    private bool patrolling;
    public int spot;
    public GameObject guard;

    public override void onInitialize()
    {
        base.onInitialize();
        FilesSpots = Blackboard.spotsFiles;
        patrolling = true;
    }


    public override Status update()
    {
        while (true)
        {


            if (patrolling == true)
            {
                float min = 65000;
                for (int i = 0; i < FilesSpots.Length; i++)
                {
                    if (Vector3.Distance(FilesSpots[i].position, guard.transform.position) < min)
                    {
                        min = Vector3.Distance(FilesSpots[i].position, guard.transform.position);
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
