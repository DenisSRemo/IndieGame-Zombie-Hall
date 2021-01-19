using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Investigate : Selector
{
    public Blackboard Blackboard;
    public override void onInitialize()
    {
        base.onInitialize();

        if (children.Count != 0)
            currentChild = children[0];
        Debug.Log(children.Count+" investigate");
    }

    public override Status update()
    {
       
        while (true)
        {
            //if (Blackboard.investigate_area == true)
            //{
            //    currentChild = children[1];
            //}
            //else
            //{
            //    if (Blackboard.investigate_door == true)
            //    {
            //        currentChild = children[2];
            //    }
            //    else
            //    {
            //        if (Blackboard.investigate_noise == true)
            //        {
            //            currentChild = children[0];
            //        }
            //    }
           
            if (Blackboard.investigate_noise == true)
            {
                currentChild = children[0];
            }

            if (Blackboard.investigate_door == true)
            {
                currentChild = children[1];
            }

            if (Blackboard.investigate_area)
            {
                currentChild = children[2];
            }
            Status s = currentChild.tick();
            if (s == Status.Success)
            {
                Debug.Log("investigation complete");
                Blackboard.investigate_noise = false;
                Blackboard.investigate_door = false;
                Blackboard.investigate_area = false;
                return Status.Success;
            }
                
            return Status.Running;
        }

        base.update();

    }

}

