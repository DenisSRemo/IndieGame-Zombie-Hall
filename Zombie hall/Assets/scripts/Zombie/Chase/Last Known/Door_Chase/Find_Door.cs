using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find_Door : Behaviour
{
    public GameObject[] doors;
   // public GameObject door;
    private float min = 1000f;
    public Zombie zombie;
    public Blackboard blackboard;
    public override void onInitialize()
    {

        base.onInitialize();
        
        doors = GameObject.FindGameObjectsWithTag("Door");
        //foreach(GameObject door in doors)
        //{
        //    if(min>Vector3.Distance(zombie.transform.position,door.transform.position))
        //    {
        //        min = Vector3.Distance(zombie.transform.position, door.transform.position);
        //    }
        //}
        //foreach (GameObject door in doors)
        //{
        //    if (min == Vector3.Distance(zombie.transform.position, door.transform.position))
        //    {
        //        blackboard.target = door.transform.position;
        //    }
        //}
       var D= doors[1].GetComponent<EnterDoor>();
        blackboard.target = D.Location.transform.position;
    }

    public override Status update()
    {
        while (true)
        {


            return Status.Success;
        }


        return base.update();
    }

    public override void onTerminate(Status status)
    {

        base.onTerminate(status);
    }
}
