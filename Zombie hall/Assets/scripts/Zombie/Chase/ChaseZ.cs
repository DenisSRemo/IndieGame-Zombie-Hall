using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseZ : Selector
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

        base.update();

    }
}
