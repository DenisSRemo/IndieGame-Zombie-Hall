using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZOMBIE1 : MonoBehaviour
{
    public BehaviourTree ZombieAI;
         
           public Sequence Patrol;
                  public Behaviour Find_Node;
                  public Behaviour Go_To_Node;
    public Selector Investigate;
           public Sequence Noise;
                  public Behaviour Go_Noise;
                  public Behaviour Look_Around_Noise;
    //public Selector Chase;
    //       public Behaviour Visible;
    //       public Behaviour Chasing;
    //       public Behaviour Stop_To_Keep_Distance;
    //       public Selector Last_Known_Location;
    //              public Sequence Same_Room;
    //                     public Behaviour Go_Location;
    //                     public Behaviour Look_Around_Room;
    //              public Sequence Door;
    //                     public Behaviour Go_To_Door;
    //                     public Behaviour Through_Door;
    //                     public Behaviour Look_Around_Door;

    public Blackboard blackboard;

    private void Start()
    {
        
        ZombieAI.addchild(Patrol);
                 Patrol.addchild(Find_Node);
                 Patrol.addchild(Go_To_Node);
        ZombieAI.addchild(Investigate);
                 Investigate.addchild(Noise);
                             Noise.addchild(Go_Noise);
                             Noise.addchild(Look_Around_Noise);
        //ZombieAI.addchild(Chase);
        //         Chase.addchild(Visible);
        //         Chase.addchild(Chasing);
        //         Chase.addchild(Stop_To_Keep_Distance);
        //         Chase.addchild(Last_Known_Location);
        //               Last_Known_Location.addchild(Same_Room);
        //               Last_Known_Location.addchild(Door);

    }
    private void Update()
    {
        Debug.Log(ZombieAI.tick());
    }
}
