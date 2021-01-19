using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visible : Behaviour
{
    public Blackboard blackboard;
    private bool _visible;
    private float time;
    private float visibleTime;

    public override void onInitialize()
    {
        
        base.onInitialize();

        time = Time.time;
        visibleTime = 1;
        Debug.Log("111111111111111");
    }

    public override Status update()
    {
        while (true)
        {
            Debug.Log("1111111111111112222");
            if (blackboard.spyseen == true && Time.time >= visibleTime + time) 
                return Status.Success;
            else
            {
              
                    return Status.Failure;
               
            }

            return Status.Running;
        }
       

        return base.update();
    }

    public override void onTerminate(Status status)
    {
        blackboard.LastKnownPosition = blackboard.spyPosition;
        base.onTerminate(status);
    }
}
