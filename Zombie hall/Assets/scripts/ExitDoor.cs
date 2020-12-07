using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    [SerializeField] private Transform A;

    [SerializeField] private player Player;
    [SerializeField] private List<Collider2D> zombies;
    public bool player_exited;
    [SerializeField]private float timing;
    void Start()
    {
        player_exited = false;

        timing = Time.time;
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
            Zombie zombie = collision.gameObject.GetComponent<Zombie>();


            if (zombie.through_door)
            {

                Vector3 u = A.transform.position;
                zombies[0].transform.position = u;
                zombies.Remove(zombies[0]);
                timing = Time.time;
                zombie.through_door = false;
            }
        }



    }

}
