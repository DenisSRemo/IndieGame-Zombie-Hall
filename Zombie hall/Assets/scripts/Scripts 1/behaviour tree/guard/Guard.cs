using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guard : MonoBehaviour
{
    public Blackboard blackboard;
    public BehaviourTree guardAI;
           public Selector Patrol;
                  public Sequence patrolling;
                         public Behaviour findNode;
                         public Behaviour goNode;
                  public Behaviour sleep;
                  public Behaviour smoke_break;
           public Sequence Chase; 
                  public Behaviour visible;
                  public Behaviour chasing;
                  public Behaviour go_last_known_location;
           public Selector Investigate;
                  public Sequence source_noise;
                         public Behaviour go_source;
                         public Behaviour look_around;
                  public Sequence area_goal;
                         public Behaviour find_nearest_goal;
                         public Selector Area;
                                public Sequence DeskArea;
                                       public Behaviour findNodeGoalDesk;
                                       public Behaviour goNodeGoalDesk;
                                public Sequence ComputerArea;
                                       public Behaviour findNodeGoalComputer;
                                       public Behaviour goNodeGoalComputer;
                                public Sequence FilesArea;
                                       public Behaviour findNodeGoalFiles;
                                       public Behaviour goNodeGoalFiles;
                  public Sequence nearest_goal;
                         public Behaviour find_near_goal;
                         public Behaviour go_near_goal;

    public NavMeshAgent guard;


    void Start()
    {
        Debug.Log("haslfAGlgfilALI");
        guardAI.addchild(Patrol);
                Patrol.addchild(patrolling);
                       patrolling.addchild(findNode);
                       patrolling.addchild(goNode);
                Patrol.addchild(smoke_break);
                Patrol.addchild(sleep);
       
        guardAI.addchild(Chase);
                Chase.addchild(visible);
                Chase.addchild(chasing);
                Chase.addchild(go_last_known_location);
        guardAI.addchild(Investigate);
                Investigate.addchild(source_noise);
                            source_noise.addchild(go_source);
                            source_noise.addchild(look_around);
                Investigate.addchild(nearest_goal);
                            nearest_goal.addchild(find_near_goal);
                            nearest_goal.addchild(go_near_goal);
                Investigate.addchild(area_goal);
                            area_goal.addchild(find_nearest_goal);
                            area_goal.addchild(Area);
                                      Area.addchild(DeskArea);
                                           DeskArea.addchild(findNodeGoalDesk);
                                           DeskArea.addchild(goNodeGoalDesk);
                                      Area.addchild(ComputerArea);
                                           ComputerArea.addchild(findNodeGoalComputer);
                                           ComputerArea.addchild(goNodeGoalComputer);
                                      Area.addchild(FilesArea);
                                           FilesArea.addchild(findNodeGoalFiles);
                                           FilesArea.addchild(goNodeGoalFiles);










                                           blackboard.Initial_Position_Guard = transform.position;
    }


    void Update()
    {
       
       Debug.Log(guardAI.tick()+"          ZZZZZZZZZZZZZZZZZZZZZZZ");
      guard.speed = blackboard.speedGuard;
      if (blackboard.GAME_OVER)
          transform.position = blackboard.Initial_Position_Guard;
    }



    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "door1")
        {
            if (blackboard.door_open_1&& blackboard.door_investigated_1 == false)
                blackboard.door_investigated_1 = true;
        }
        if (col.gameObject.tag == "door2")
        {

            if (blackboard.door_open_2 && blackboard.door_investigated_2 == false)
                blackboard.door_investigated_2 = true;
        }
        if (col.gameObject.tag == "door3")
        {

            if (blackboard.door_open_3 && blackboard.door_investigated_3 == false)
                blackboard.door_investigated_3 = true;
        }
    }




    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "door1")
        {

        }
        if (col.gameObject.tag == "door2")
        {

        }
        if (col.gameObject.tag == "door3")
        {

        }
    }

    

}
