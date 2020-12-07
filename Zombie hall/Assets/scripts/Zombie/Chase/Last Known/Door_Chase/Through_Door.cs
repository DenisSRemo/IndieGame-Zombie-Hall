using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Through_Door : Behaviour
{


    public Zombie zombie;
    public override void onInitialize()
    {

        base.onInitialize();

        
    }

    public override Status update()
    {
        while (true)
        {
            zombie.through_door = true;
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
