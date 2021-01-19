using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class go_source : Behaviour
{
    public Blackboard Blackboard;
    public NavMeshAgent guard;
    public GameObject Guard;

    public override void onInitialize()
    {
        base.onInitialize();
        guard.GetComponent<NavMeshAgent>();
    }

    public override Status update()
    {
        while (true)
        {


            guard.destination = Blackboard.SourceNoise;
            if (Vector3.Distance(Guard.transform.position, Blackboard.SourceNoise) <= 6f)
            {
                Debug.Log("CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC");
                return Status.Success;
            }
               

            return Status.Running;
        }

        return base.update();


    }

    public override void onTerminate(Status status)
    {
        base.onTerminate(status);
    }
}
