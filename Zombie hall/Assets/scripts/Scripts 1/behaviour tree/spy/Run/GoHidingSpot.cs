using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoHidingSpot : Behaviour
{
    public Blackboard Blackboard;
    public NavMeshAgent spy;
    private Transform[] HidingSpots;
    public int spot;
    public GameObject Spy;

    public override void onInitialize()
    {
        base.onInitialize();
        spy.GetComponent<NavMeshAgent>();
        HidingSpots = Blackboard.Hidding_Spots;
        spot = Blackboard.targetHidingSpot;
        Blackboard.speedSpy = 20.0f;
    }

    public override Status update()
    {
        while (true)
        {

            spy.destination = HidingSpots[spot].position;
            if (Vector3.Distance(Spy.transform.position, HidingSpots[spot].position) <= 2f)
            {

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
