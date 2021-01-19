using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : Selector
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
            if (blackboard.desk)
            {
                currentChild = children[0];
            }
            if (blackboard.computer)
            {
                currentChild = children[1];
            }
            if (blackboard.files)
            {
                currentChild = children[2];
            }
            if (s == Status.Success)
            {
                blackboard.desk = false;
                blackboard.computer = false;
                blackboard.files = false;
                
                return Status.Success;
            }
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
