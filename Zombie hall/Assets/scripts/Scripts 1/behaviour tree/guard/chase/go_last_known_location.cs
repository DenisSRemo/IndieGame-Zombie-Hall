using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class go_last_known_location : Behaviour
{
    public Blackboard blackboard;
    private Vector3 spy_pos;
    public NavMeshAgent guard;

    public override void onInitialize()
    {
        spy_pos = blackboard.LastKnownPosition;
        guard.GetComponent<NavMeshAgent>();
        base.onInitialize();
    }


    public override Status update()
    {
        while (true)
        {


            guard.destination = spy_pos;
            if (Vector3.Distance(transform.position, spy_pos) <= 6.0f)
                return Status.Success;
           
                return Status.Running;
            
        }

        return base.update();
    }


    public override void onTerminate(Status status)
    {
        base.onTerminate(status);
    }
}
