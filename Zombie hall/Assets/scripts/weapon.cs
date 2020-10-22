using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private bool allow=true;
    public float firerate = 0.1f;
    private float timetoshoot = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if(Time.time-timetoshoot>=firerate)
            {
                Shoot();
                timetoshoot = Time.time;
            }
           
        }
    }



    void Shoot()
    {
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }
}
