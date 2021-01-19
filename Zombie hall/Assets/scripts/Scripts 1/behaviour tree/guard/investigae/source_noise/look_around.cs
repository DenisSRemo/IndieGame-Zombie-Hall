using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_around : Behaviour
{
    private float time;
    private float breakTime;
    public Blackboard blackboard;
    public float initialSpeed;
    public override void onInitialize()
    {
        base.onInitialize();
        time = Time.time;
        breakTime = 5;
        initialSpeed = blackboard.speedGuard;
    }

    public override Status update()
    {
        while (true)
        {
            if (Time.time >= time + breakTime)
            {
                blackboard.speedGuard = 10.0f;
                Debug.Log("DDDDDDDDDDDDDDDDDDDDDDDDDDD");
                blackboard.investigate_noise = false;
                return Status.Success;
            }

            else
            {
                blackboard.speedGuard = 0;
                return Status.Running;
            }
        }
       

        return base.update();

    }

    public override void onTerminate(Status status)
    {
        base.onTerminate(status);
        blackboard.slept = false;
    }
}
