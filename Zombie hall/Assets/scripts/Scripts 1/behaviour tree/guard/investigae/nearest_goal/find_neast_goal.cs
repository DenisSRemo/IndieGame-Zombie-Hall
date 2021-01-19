using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class find_neast_goal : Behaviour
{
    public Blackboard Blackboard;
    private Transform[] neargoalSpots;
    private float min = 65000;
    private int spot;
   
    private bool investigating;
   
    public GameObject guard;

    public override void onInitialize()
    {
        base.onInitialize();
        neargoalSpots = Blackboard.ObjectiveSpots;
        investigating = true;
    }


    public override Status update()
    {

        while (true)
        {

            if (investigating == true)
            {

                float min = 65000;
                for (int i = 0; i < neargoalSpots.Length; i++)
                {
                    if (Vector3.Distance(neargoalSpots[i].position, guard.transform.position) < min)
                    {
                        min = Vector3.Distance(neargoalSpots[i].position, guard.transform.position);
                        spot = i;
                    }
                }


                investigating = false;

                Blackboard.targetneargoalNode = spot;
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
