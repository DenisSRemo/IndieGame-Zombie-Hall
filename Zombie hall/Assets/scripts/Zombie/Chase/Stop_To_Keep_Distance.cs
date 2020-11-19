using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_To_Keep_Distance : Behaviour
{
    public override void onInitialize()
    {

        base.onInitialize();

       
    }

    public override Status update()
    {
        while (true)
        {
          

            return Status.Running;
        }


        return base.update();
    }

    public override void onTerminate(Status status)
    {
       
        base.onTerminate(status);
    }
}
