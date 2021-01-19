using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleep : Behaviour
{
    private float time;
    private float sleepTime;
    public Blackboard blackboard;
    public float initialSpeed;
    public override void onInitialize()
    {
        base.onInitialize();
        time = Time.time;
        sleepTime = 10;
        initialSpeed = blackboard.speedGuard;
    }

    public override Status update()
    {
        while (true)
        {


            if (Time.time >= time + sleepTime)
            {
                blackboard.speedGuard = 10.0f;
                return Status.Success;
            }

            else
            {
                blackboard.speedGuard = 0;
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
