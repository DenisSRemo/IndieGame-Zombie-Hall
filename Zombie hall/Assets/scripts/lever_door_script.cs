using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever_door_script : MonoBehaviour
{

    public Transform Position1;
    public Transform Position2;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            if(door.transform.position==Position1.transform.position)
            {
                door.transform.position = Position2.transform.position;
            }
            else
                 if (door.transform.position == Position2.transform.position)
            {
                door.transform.position = Position1.transform.position;
            }
        }
    }
}
