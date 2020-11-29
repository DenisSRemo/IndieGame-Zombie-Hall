using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Investigate : Selector
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
                return Status.Success;
            
            return Status.Running;
        }

        base.update();

    }
}
