using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Experimental.GlobalIllumination;

public class spy : MonoBehaviour
{
    public BehaviourTree SpyAI;
           public Sequence Goal;
                  public Behaviour Reach;
                  public Behaviour GoBack;
           public Sequence Run;
                  public Behaviour FindHidingSpot;
                  public Behaviour GoHidingSpot;
                  public Behaviour Wait;


          public Blackboard blackboard;

          public NavMeshAgent Spy;


        void Start()
                  {
                      Debug.Log("jhssszdkzjchkzjcjzhk");
                      
                      SpyAI.addchild(Goal);
                            Goal.addchild(Reach);
                            Goal.addchild(GoBack);
                      SpyAI.addchild(Run);
                            Run.addchild(FindHidingSpot);
                            Run.addchild(GoHidingSpot);
                            Run.addchild(Wait);
                      blackboard.Initial_Position_Spy = transform.position;
                      blackboard.Initial_Position_Spy = transform.position;
                  }



                  void Update()
                  {
                      Debug.Log(SpyAI.tick());
                      Spy.speed = blackboard.speedSpy;
                      if (blackboard.GAME_OVER)
                          transform.position = blackboard.Initial_Position_Spy;
                  }


























































    //public NavMeshAgent Spy;
    //public Transform[] ObjectiveSpots;
    //public Transform[] Hidding_Spots;
    //private int spot;
    //public Blackboard Blackboard;
    //public bool hide;
    //private Vector3 HidingSpot;

    //void Start()
    //{
    //    Spy.GetComponent<NavMeshAgent>();
    //    spot = Blackboard.number_simulations;
    //    Spy.speed = 15;
    //    // Blackboard.Initial_Position_Spy = transform.position;
    //    hide = false;
    //}


    //void Update()
    //{
    //    if (Blackboard.spyseen)
    //    {
    //        hide = true;
    //    }
    //    else
    //    {
    //        Objective(spot);
    //    }

    //    if (hide)
    //    {
    //        Spy.destination = HidingSpot;
    //    }

    //}


    //void Objective(int spot)
    //{
    //    switch (spot % 3)
    //    {
    //        case 0:
    //            Spy.destination = ObjectiveSpots[spot].position;
    //            break;
    //        case 1:
    //            Spy.destination = ObjectiveSpots[spot].position;
    //            break;
    //        case 2:
    //            Spy.destination = ObjectiveSpots[spot].position;
    //            break;
    //    }
    //}

    //void Hiding()
    //{
    //    float min = 65000;

    //    for (int i = 0; i < Hidding_Spots.Length; i++)
    //    {
    //        if (Vector3.Distance(transform.position, Hidding_Spots[i].position) < min)
    //        {
    //            min = Vector3.Distance(transform.position, Hidding_Spots[i].position);
    //            spot = i;
    //        }
    //    }

    //    HidingSpot = Hidding_Spots[spot].position;
    //}





}
