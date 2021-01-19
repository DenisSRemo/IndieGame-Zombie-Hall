using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class source_noise : Sequence
{
    public Blackboard blackboard;

    public override void onInitialize()
    {
        base.onInitialize();
        if(children.Count!=0)
        currentChild = children[0];
        Debug.Log(children.Count+" source noise");
    }

    public override Status update()
    {
        
        while (true)
        {
            Status s = currentChild.tick();
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            if (currentChild == children[0] && s == Status.Success)
            {
                currentChild = children[1];
                Debug.Log("BBBBBBBBBBBBBBBBBBBBBBBB");
            }



            if (currentChild == children[1] && s == Status.Success)
            {
                Debug.Log("EEEEEEEEEEEEEEEEEEEEEEEE");
                return Status.Success;
            }
                
            return Status.Running;
            base.update();
        }

        return Status.Invalid;
    }
}
