using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chasing : Behaviour
{
    public NavMeshAgent guard;
    public Blackboard Blackboard;
    public GameObject Guard;
    public GameObject Spy;
    public override void onInitialize()
    {
        base.onInitialize();
        guard.GetComponent<NavMeshAgent>();
        
    }

    public override Status update()
    {
        while (true)
        {


            if (Blackboard.spyseen == true)
            {
                Blackboard.speedGuard = 25;
                guard.destination = Spy.transform.position;
                if (Vector3.Distance(Guard.transform.position, Spy.transform.position) < 10f)
                {
                    Debug.Log("SPYYYYYYYYYYYYY CAAAAAAAAAAAAAAAAAAAAUGHT");
                    Blackboard.GAME_OVER = true;
                    return Status.Success;
                }

                return Status.Running;
            }
            else
            {
                Blackboard.speedGuard = 10;
                Blackboard.LastKnownPosition = Spy.transform.position;
                return Status.Failure;
            }
        }

        return base.update();
    }


    public override void onTerminate(Status status)
    {
        base.onTerminate(status);
    }
}
