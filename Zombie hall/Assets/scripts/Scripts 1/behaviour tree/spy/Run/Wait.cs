using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wait : Behaviour
{
    private float time;
    private float waitTime;
    public Blackboard blackboard;
    public override void onInitialize()
    {
        base.onInitialize();
        time = Time.time;
        waitTime = 5;
        
    }

    public override Status update()
    {
        while (true)
        {


            if (Time.time >= time + waitTime)
            {
                blackboard.speedSpy = 10.0f;
                return Status.Success;
            }

            else
            {
                blackboard.speedSpy = 0;
                return Status.Running;
            }
            // return Status.Success;
        }

        return base.update();

    }

    public override void onTerminate(Status status)
    {
        base.onTerminate(status);
        //blackboard.slept = true;
    }
}
