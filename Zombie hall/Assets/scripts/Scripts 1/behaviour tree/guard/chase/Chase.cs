using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : Sequence
{

    public Blackboard Blackboard;
    public override void onInitialize()
    {
        base.onInitialize();
        if(children.Count!=0)
        currentChild = children[0];
        Debug.Log("chase");
        Debug.Log("chase children "+children.Count);
    }

    public override Status update()
    {
       
        while (true)
        {
            Status s = currentChild.tick();
            if (currentChild == children[0] && s == Status.Success)
                currentChild = children[1];
            if (s == Status.Failure && currentChild == children[0])
                return Status.Failure;
            if (s == Status.Failure && currentChild == children[1])
                currentChild = children[2];
            if (s == Status.Success && currentChild == children[1])
                return Status.Success;
            if (currentChild == children[2]&& s==Status.Success)
                return Status.Failure;

            return Status.Running;

        }

        return Status.Invalid;
       return base.update();
    }
}
