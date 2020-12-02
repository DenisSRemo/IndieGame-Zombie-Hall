using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Last_Known_Location : Selector
{

    public Zombie zombie;
    public Blackboard blackboard;
    public override void onInitialize()
    {
        base.onInitialize();
       
    }

    public override Status update()
    {

        while (true)
        {
            zombie.transform.position = Vector3.MoveTowards(zombie.transform.position,blackboard.Last_known_position.position , blackboard.speed * Time.deltaTime);
            if (Vector3.Distance(zombie.transform.position,blackboard.Last_known_position.position) <= 1f)
            {
                return Status.Success;
            }

            return Status.Running;
        }

        base.update();

    }
}
