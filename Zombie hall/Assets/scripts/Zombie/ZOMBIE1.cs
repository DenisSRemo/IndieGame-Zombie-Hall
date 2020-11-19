using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZOMBIE1 : MonoBehaviour
{
    public BehaviourTree ZombieAI;
           public Selector Chase;
                  public Behaviour Visible;
                  public Behaviour Chasing;
                  public Behaviour Stop_To_Keep_Distance;
                  public Selector Last_Known_Location;
                         public Sequence Same_Room;
                                public Behaviour Go_Location;
                                public Behaviour Look_Around_Room;
                         public Sequence Door;
                                public Behaviour Go_To_Door;
                                public Behaviour Through_Door;
                                public Behaviour Look_Around_Door;
           public Sequence Patrol;
                  public Behaviour Find_Node;
                  public Behaviour Go_To_Node;
           public Selector Investigate;
                  public Sequence Noise;
                         public Behaviour Go_Noise;
                         public Behaviour Look_Around_Noise;
}
