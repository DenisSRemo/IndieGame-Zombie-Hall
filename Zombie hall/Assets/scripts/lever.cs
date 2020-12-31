using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{


    [SerializeField] private GameObject Trap_door;


    void Start()
    {
        
    }


    void Update()
    {
        
    }

  
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(Trap_door);
        }
    }
}
