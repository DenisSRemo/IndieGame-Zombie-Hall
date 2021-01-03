using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private bool allow=true;
    public float firerate = 0.1f;
    private float timetoshoot = 0f;
    public int nrbullets=0;
    public int nrBulletsTotal = 120;
    public TextMeshProUGUI text_ammo;
    private void Start()
    {
        text_ammo.text = 0 + "/" + nrBulletsTotal;
    }

    void Update()
    {
        
        if (Input.GetMouseButton(0)&&nrbullets>0&&nrBulletsTotal>=0)
        {
            if(Time.time-timetoshoot>=firerate)
            {
                Shoot();
                timetoshoot = Time.time;
                nrbullets--;
            }
            text_ammo.text = nrbullets + "/" + nrBulletsTotal;
        }
        else
        {
            //before shooting you must press R to reload
            //the magazine has 30 bullets
            if (Input.GetKeyDown(KeyCode.R)&&nrBulletsTotal>0&&nrbullets!=30)
            {
                if (nrBulletsTotal < 30 && nrBulletsTotal > 0&& nrBulletsTotal + nrbullets<=30)
                {
                    nrBulletsTotal = nrBulletsTotal + nrbullets;
                    nrbullets = nrBulletsTotal;
                    nrBulletsTotal = 0;
                }
                   
                else
                {
                    nrBulletsTotal = nrBulletsTotal + nrbullets;
                    nrBulletsTotal = nrBulletsTotal - 30;
                    nrbullets = 30;
                    
                }
                  
            }
            text_ammo.text = nrbullets + "/" + nrBulletsTotal;
        }
            
    }



    void Shoot()
    {
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }
}
