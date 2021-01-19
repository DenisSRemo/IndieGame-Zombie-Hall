using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;

public class Patrol : Selector
{
    public Blackboard blackboard;
    public override void onInitialize()
    {
       
        base.onInitialize();
       if(children.Count!=0)
        currentChild = children[0];
        
    }

    public override Status update()
    {
        
        

        while (true)
        {
            Status s = currentChild.tick();
            if (/*blackboard.slept == true && */currentChild == children[1] && currentChild.tick() == Status.Success)
            {
                currentChild = children[2];
                
            }
            else
            {
                if (/*blackboard.slept == false && */currentChild == children[2] && currentChild.tick() == Status.Success)
                {
                    currentChild = children[0];
                }
                else
                {
                    if (currentChild.tick() == Status.Success)
                    {
                        return Status.Running;
                    }
                    

                }
            }

            if (blackboard.spyseen == true)
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
