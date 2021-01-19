using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpyAI : BehaviourTree
{

    public Blackboard blackboard;
    public bool RUN;


    public override void onInitialize()
    {
        base.onInitialize();
        if (children.Count != 0)
            currentChild = children[0];

        Debug.Log(children.Count);

        RUN = false;
    }

    public override Status update()
    {


        while (true)
        {
            Status s = currentChild.tick();
            if (blackboard.spyseen)
                RUN = true;


            if (RUN&&currentChild==children[0])
            {
                currentChild = children[1];
                return Status.Running;
            }

            if (currentChild == children[1] && s == Status.Success)
            {
                RUN = false;
                currentChild = children[0];
            }
                
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
