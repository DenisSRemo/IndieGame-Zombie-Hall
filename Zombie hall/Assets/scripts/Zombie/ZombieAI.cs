using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : BehaviourTree
{
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
            

         
            return Status.Running;
        }


        Debug.Log("bbcccccccccccccccccccccccccccccccccccccb");

        return Status.Invalid;
        return base.update();
    }

    public override void onTerminate(Status status)
    {
        base.onTerminate(status);
    }
}
