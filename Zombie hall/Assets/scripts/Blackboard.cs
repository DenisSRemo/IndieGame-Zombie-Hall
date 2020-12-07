using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackboard : MonoBehaviour
{
    public player Player;
    public float speed;
    public Transform player;
    public Transform zombie;
    public List<Transform> Nodes;
    public Transform Last_known_position;
    public Transform Noise_Location;
    public Transform target;
    public bool patrol;
    public bool investigate;
    public bool chase;
    public bool playerseen;
    public int i;
    public bool to_close;


    private void Start()
    {
        speed = 2f;
        patrol = true;
        investigate = false;
        chase = false;
        playerseen=false;
        i = 0;
        to_close = false;
        //Nodes.Add(zombie);
        //Nodes.Add(zombie);
        //Vector3 u = zombie.transform.position;
        //Vector3 v = zombie.transform.position;
        //u.x = u.x - 10;
        //v.x = v.x + 10;
        //Nodes[0].transform.position = u;
        //Nodes[1].transform.position = v;
    }


    private void Update()
    {
        player = Player.transform;
        //zombie = gameObject.transform;
        
    }
}
