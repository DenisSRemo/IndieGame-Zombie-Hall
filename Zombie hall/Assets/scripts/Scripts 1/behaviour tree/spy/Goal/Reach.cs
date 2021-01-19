using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Reach : Behaviour
{
    public NavMeshAgent Spy;
    public Transform[] ObjectiveSpots;
    private int spot;
    public Blackboard Blackboard;
    private Vector3 HidingSpot;
    public GameObject spy;

    public override void onInitialize()
    {
        base.onInitialize();
        Spy.GetComponent<NavMeshAgent>();
        spot = Blackboard.number_simulations;
        ObjectiveSpots = Blackboard.ObjectiveSpots;
        Spy.speed = 15;
      
        
    }

    public override Status update()
    {
        while (true)
        {
            switch (spot % 3)
            {
                case 0:
                    Spy.destination = ObjectiveSpots[spot].position;
                    break;
                case 1:
                    Spy.destination = ObjectiveSpots[spot].position;
                    break;
                case 2:
                    Spy.destination = ObjectiveSpots[spot].position;
                    break;

            }

            if (Vector3.Distance(spy.transform.position, ObjectiveSpots[spot].position) < 5f)
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
