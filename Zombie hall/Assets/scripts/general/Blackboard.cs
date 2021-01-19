using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Blackboard : MonoBehaviour
{
    public NavMeshAgent nav_guard;
    public Vector3 spyPosition;
    public Vector3 guardPosition;
    public Vector3 LastKnownPosition;
    public Vector3 SourceNoise;
    public Vector3 Initial_Position_Guard;
    public Vector3 Initial_Position_Spy;
    public GameObject spy;
    public GameObject guard;
    public bool spyseen;
    public bool goalseen;
    public bool hidingseen;
    public float distanceGuardSpy;
    public bool computer;
    public bool desk;
    public bool files;
    public Transform[] spots;
    public Transform[] spotsComputer;
    public Transform[] spotsDesk;
    public Transform[] spotsFiles;
    public Transform[] ObjectiveSpots;
    public Transform[] ObjectiveSpotsForGuard;
    public Transform[] Hidding_Spots;
    public float speedGuard;
    public Transform[] moveSpots;
    public int targetNode = 0;
    public int targetgoalNode = 0;
    public int targetneargoalNode = 0;
    public float min = 65000;
    public Camera camera;
    public bool Patrolling;
    public bool initial_patrolling;
    public int spotPatrol;
    public float time;
    public bool PATROL;
    public bool INVESTIGATE;
    public bool CHASE;
    public bool GAME_OVER;
    public bool SPYCAUGHT;
    public bool slept;
    public bool investigate_noise;
    public bool investigate_area;
    public bool investigate_door;
    public bool door_open_1;
    public bool door_open_2;
    public bool door_open_3;
    public bool door_investigated_1;
    public bool door_investigated_2;
    public bool door_investigated_3;
    public bool door_seen;
    public int number_simulations;
    public int targetObjective;
    public int targetHidingSpot;
    public float speedSpy;
    void Start()
    {
        spyPosition = spy.transform.position;
        guardPosition = guard.transform.position;
        spyseen = false;
        goalseen = false;
        hidingseen = false;
        computer = false;
        desk = false;
        files = false;
        Patrolling = false;
        time = Time.time;
        PATROL = false;
        INVESTIGATE = false;
        CHASE = false;
        GAME_OVER = false;
        SPYCAUGHT = false;
        slept = false;
        investigate_area = false;
        investigate_door = false;
        investigate_noise = false;
        speedGuard = 10;
        door_open_1 = false;
        door_open_2 = false;
        door_open_3 = false;
        door_investigated_1=false;
        door_investigated_2=false;
        door_investigated_3=false;
        door_seen = false;
        number_simulations = 0;
        speedSpy = 10;
    }

    //void Update()
    //{
       
    //    spyPosition = spy.transform.position;
    //    guardPosition = guard.transform.position;

    //    distanceGuardSpy = Vector3.Distance(spyPosition, guardPosition);
    //    if (distanceGuardSpy <= 60.0f&&investigate_noise==false)
    //    {
    //        SourceNoise =spy.transform.position;
    //        investigate_noise = true;
    //    }

    //    if (door_investigated_1 || door_investigated_2 || door_investigated_3)
    //    {
    //        investigate_door = true;
    //    }

    //    if (GAME_OVER == true)
    //    {
    //        number_simulations++;
    //        GAME_OVER = false;
    //    }

    //    if (goalseen && (desk || files || computer))
    //    {
    //        investigate_area = true;
    //    }
        
    //}
}
