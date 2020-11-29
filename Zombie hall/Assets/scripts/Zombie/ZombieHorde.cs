using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHorde : MonoBehaviour
{


    [SerializeField] List<Zombie> horde;
    [SerializeField] Transform door;
    [SerializeField] Transform player;
    private Transform target;
    private float speed;

    private float timing;









    void Start()
    {
        timing = Time.time;
        speed = 2f;
    }

 
    void Update()
    {
        for(int i=0;i<horde.Count;i++)
        {
            if (player.transform.position.y - horde[i].transform.position.y <= 5)
            {
                //horde[i].target = player;
                //AttackTarget(player, horde[i]);
            }


            else
            {

                //horde[i].target = door;
                //AttackTarget(door, horde[i]);
            }
        }
        
    }



    private void AttackTarget(Transform target,Zombie ob)
    {
        
        ob.transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
