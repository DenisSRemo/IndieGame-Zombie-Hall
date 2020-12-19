using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : BehaviourTree
{
    public Blackboard blackboard;
    public override void onInitialize()
    {
        base.onInitialize();
        if (children.Count != 0)
            currentChild = children[0];

        


    }

    public override Status update()
    {


        while (true)
        {
            //if (blackboard.chase)
            //    currentChild = children[0];
            //else
            //    if (blackboard.investigate)
            //    currentChild = children[2];
            //else
            //    if (blackboard.patrol)
            //    currentChild = children[1];

            currentChild = children[2];
            Status s = currentChild.tick();
            

         
            return Status.Running;
        }


        

        return Status.Invalid;
        return base.update();
    }

    public override void onTerminate(Status status)
    {
        base.onTerminate(status);
    }
}
