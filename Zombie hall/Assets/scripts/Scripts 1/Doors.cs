using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    private Animator animator;
    public bool doorOpen;
    public Blackboard Blackboard;

    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();

    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "guard"||col.gameObject.tag=="spy")
        {
            doorOpen = true;
            Door_action("Open");
        }
    }




    void OnTriggerExit(Collider col)
    {
        if (doorOpen&&col.gameObject.tag=="guard")
        {
            doorOpen = false;
            Door_action("Close");
        }
        else
        {
           
            Blackboard.door_open_1 = true;
        }
    }

    void Door_action(string direction)
    {
        animator.SetTrigger(direction);
    }


    void Update()
    {
        
    }
}
