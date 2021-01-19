using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class FieldOfVision : MonoBehaviour
{
    public float viewRadius;
    [Range(0,360)]
    public float viewAngle;

    public LayerMask targetMask;
    public LayerMask obstacleMask;
    
    public LayerMask doorsMask;
    public List<Transform> visibleTargets=new List<Transform>();
    public List<Transform>visibleDoors=new List<Transform>();
    public Blackboard blackboard;


    void Start()
    {
        
    }

    void Update()
    {
        FindVisibleTarget();
        FindVisibleDoors();
        
    }

   
    void FindVisibleTarget()
    {
        visibleTargets.Clear();
        Collider[] targetInViewRadius = Physics.OverlapSphere(transform.position,viewRadius,targetMask);
        
        if(targetInViewRadius.Length!=0)
        {
            Transform target = targetInViewRadius[0].transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;
            if (Vector3.Angle(transform.forward, directionToTarget) < viewAngle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);
                if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, obstacleMask))
                {
                    visibleTargets.Add(target);
                   // blackboard.spyseen = true;
                    Debug.Log("spy SEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEN");
                }
            }

        }
        else
        {
            //blackboard.spyseen = false;
        }
        
    }
    void FindVisibleDoors()
    {
        visibleDoors.Clear();
        Collider[] goalInViewRadius = Physics.OverlapSphere(transform.position, viewRadius, doorsMask);

        if (goalInViewRadius.Length != 0)
        {
            Transform goal = goalInViewRadius[0].transform;
            Vector3 directionToTarget = (goal.position - transform.position).normalized;
            if (Vector3.Angle(transform.forward, directionToTarget) < viewAngle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, goal.position);
                if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, obstacleMask))
                {
                    visibleDoors.Add(goal);
                   // blackboard.goalseen = true;
                }
            }

           
        }
        else
        {
            //blackboard.goalseen = false;
        }
       
    }

  

    public Vector3 DirectionFromAngle(float angleInDegrees,bool angleIsGlobal)
    {
        if (!angleIsGlobal)
        {
            angleInDegrees += transform.eulerAngles.y;
        }
        return  new Vector3(Mathf.Sin(angleInDegrees*Mathf.Deg2Rad),0,Mathf.Cos(angleInDegrees*Mathf.Deg2Rad));
    }
}
