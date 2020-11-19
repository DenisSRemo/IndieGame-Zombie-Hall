using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterDoor : MonoBehaviour
{
    [SerializeField] private Transform B;
    
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
        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.S))
        {

            Vector3 u = B.transform.position;
            
            Player.transform.position = u;





        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.S))
            {

            Vector3 u = B.transform.position;
            
            Player.transform.position = u;
        }



        //if (collision.tag == "Zombie")
        //{
        //    Zombie zombie = collision.gameObject.GetComponent<Zombie>();


        //    if (zombie.exiting)
        //    {

        //        Vector3 u = A.transform.position;
        //        zombies[0].transform.position = u;
        //        zombies.Remove(zombies[0]);
        //        timing = Time.time;
        //    }
        //}



    }

}
