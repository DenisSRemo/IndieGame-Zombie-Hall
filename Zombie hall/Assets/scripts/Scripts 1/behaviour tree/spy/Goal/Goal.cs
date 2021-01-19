using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : Sequence
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
            Status s = currentChild.tick();

            if (currentChild == children[0] && s == Status.Success)
            {
                currentChild = children[1];
                return Status.Running;
            }



            if (currentChild == children[1] && s == Status.Success)
                return Status.Success;

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
