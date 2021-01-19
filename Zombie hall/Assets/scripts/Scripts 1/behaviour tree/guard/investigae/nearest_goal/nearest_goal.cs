using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearest_goal : Sequence
{
    public Blackboard blackboard;

    public override void onInitialize()
    {
        base.onInitialize();
        if (children.Count != 0)
            currentChild = children[0];
        Debug.Log(children.Count + " investigate door");
    }

    public override Status update()
    {

        while (true)
        {
            Status s = currentChild.tick();
            if (currentChild == children[0] && s == Status.Success)
            {
                currentChild = children[1];
            }



            if (currentChild == children[1] && s == Status.Success)
            {
                blackboard.door_investigated_1 = false;
                blackboard.door_investigated_2 = false;
                blackboard.door_investigated_3 = false;
                return Status.Success;
            }

            return Status.Running;
            base.update();
        }

        return Status.Invalid;
    }
}
