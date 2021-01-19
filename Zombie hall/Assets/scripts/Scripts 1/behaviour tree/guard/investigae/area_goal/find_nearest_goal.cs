using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class find_nearest_goal : Behaviour
{
    public Blackboard Blackboard;
    private Transform[] ObjectiveSpots;
    public int spot;
    public GameObject guard;
    private bool investigating;

    public override void onInitialize()
    {
        base.onInitialize();
        ObjectiveSpots = Blackboard.ObjectiveSpots;
        investigating = true;
    }


    public override Status update()
    {
        while (true)
        {


            if (investigating == true)
            {
                float min = 65000;
                for (int i = 0; i < ObjectiveSpots.Length; i++)
                {
                    if (Vector3.Distance(ObjectiveSpots[i].position, guard.transform.position) < min)
                    {
                        min = Vector3.Distance(ObjectiveSpots[i].position, guard.transform.position);
                        spot = i;
                    }

                }

                investigating = false;
                Blackboard.targetObjective = spot;

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
