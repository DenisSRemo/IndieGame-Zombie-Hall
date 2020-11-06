using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHorde : MonoBehaviour
{


    [SerializeField] List<Zombie> horde;
    [SerializeField] Transform door;
    [SerializeField] Transform player;


    private float timing;









    void Start()
    {
        timing = Time.time;
    }

 
    void Update()
    {
        //for(int i = 0;i < horde.Count;i++)
        //    {
        //    if (horde[i].exiting == true)
        //    {
        //        for (int j = 0; j < horde.Count; j++)
        //            horde[j].target = horde[j].transform;
        //       horde.Remove(horde[i]);
        //        if(Time.time-timing>=3)
        //        {
        //            for (int j = 0; j < horde.Count; j++)
        //                horde[j].target = door;
        //            timing = Time.time;
        //        }
        //    }

        //    else
        //    {
        //        for (int j = 0; j < horde.Count; j++)
        //            if (player.transform.position.y - gameObject.transform.position.y <= 5)
        //                horde[j].target = player;
        //    }


        //}
    }
}
