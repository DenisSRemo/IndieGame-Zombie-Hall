using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardAI : BehaviourTree
{
    public Blackboard blackboard;
   
   
    public override void onInitialize()
    {
        base.onInitialize();
        if(children.Count!=0)
        currentChild = children[0];

        blackboard.PATROL = true;
        

    }

    public override Status update()
    {
       
        
        while (true)
        {
            Status s = currentChild.tick();
            if (blackboard.spyseen == true)
            {
                currentChild = children[1];
                blackboard.investigate_area = false;
                blackboard.investigate_door = false;
                blackboard.investigate_noise = false;
            }

            if ((blackboard.investigate_area == true || blackboard.investigate_noise == true ||
                blackboard.investigate_door == true)&&blackboard.spyseen==false)
                currentChild = children[2];
            if (currentChild == children[2] && s == Status.Success)
                currentChild = children[0];
            if (currentChild == children[1] && s == Status.Failure)
                currentChild = children[0];
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
