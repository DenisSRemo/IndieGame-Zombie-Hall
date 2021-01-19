using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoBack : Behaviour
{
    public NavMeshAgent Spy;
   
    public Blackboard Blackboard;
  
    private Vector3 HidingSpot;
    public GameObject spy;

    public override void onInitialize()
    {
        base.onInitialize();
        Spy.GetComponent<NavMeshAgent>();
       
        Spy.speed = 15;


    }

    public override Status update()
    {
        while (true)
        {
           
                
                    Spy.destination = Blackboard.Initial_Position_Spy;




                    if (Vector3.Distance(spy.transform.position, Blackboard.Initial_Position_Spy) <= 6f)
                    {
                        Blackboard.GAME_OVER = true;
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
