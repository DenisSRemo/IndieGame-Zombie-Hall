using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindHidingSpot : Behaviour
{
    public Blackboard Blackboard;
    private Transform[] HidingSpots;
    private bool hide;
    public int spot;
    public GameObject spy;

    public override void onInitialize()
    {
        base.onInitialize();
        HidingSpots = Blackboard.Hidding_Spots;
        hide = true;
    }


    public override Status update()
    {
        while (true)
        {


            if (hide == true)
            {
                float min = 65000;
                for (int i = 0; i < HidingSpots.Length; i++)
                {
                    if (Vector3.Distance(HidingSpots[i].position, spy.transform.position) < min)
                    {
                        min = Vector3.Distance(HidingSpots[i].position, spy.transform.position);
                        spot = i;
                    }

                }

                hide = false;
                Blackboard.targetHidingSpot = spot;

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
