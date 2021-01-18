using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    [SerializeField] private Transform A;

    [SerializeField] private player Player;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.W))
        {
            Vector3 u = A.transform.position;
            
            collision.transform.position =u;
        }


       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
            if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.W))
            {

            Vector3 u = A.transform.position;
          
            Player.transform.position = u;
        }


        

        if (collision.tag == "Zombie")
        {
          

          
        }



    }

}
