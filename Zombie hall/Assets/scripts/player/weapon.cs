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
    public int nrBulletsTotal = 60;
    public TextMeshProUGUI text_ammo;


    public bool pistol;
    public bool SMG;
    public bool AR;


    private void Start()
    {
       text_ammo.text = 0 + "/" + nrBulletsTotal;
    }

    void Update()
    {
        if (pistol)
        {

            firerate = 0.7f;
            if (Input.GetMouseButtonDown(0) && nrbullets > 0 && nrBulletsTotal >= 0)
            {
                if (Time.time - timetoshoot >= firerate)
                {
                    Shoot();
                    timetoshoot = Time.time;
                    nrbullets--;
                }
                text_ammo.text = nrbullets + "/" + nrBulletsTotal;
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.R) && nrBulletsTotal > 0 && nrbullets != 7)
                {
                    if (nrBulletsTotal < 7 && nrBulletsTotal > 0 && nrBulletsTotal + nrbullets <= 7)
                    {
                        nrBulletsTotal = nrBulletsTotal + nrbullets;
                        nrbullets = nrBulletsTotal;
                        nrBulletsTotal = 0;
                    }

                    else
                    {
                        nrBulletsTotal = nrBulletsTotal + nrbullets;
                        nrBulletsTotal = nrBulletsTotal - 7;
                        nrbullets = 7;

                    }

                }
                text_ammo.text = nrbullets + "/" + nrBulletsTotal;
            }
        }

        if(SMG)
        {
            firerate = 0.1f;

            if (Input.GetMouseButtonDown(0) && nrbullets > 0 && nrBulletsTotal >= 0)
            {
                if (Time.time - timetoshoot >= firerate)
                {
                    Shoot();
                    timetoshoot = Time.time;
                    nrbullets--;
                }
                if (Time.time - timetoshoot >= firerate)
                {
                    Shoot();
                    timetoshoot = Time.time;
                    nrbullets--;
                }
                if (Time.time - timetoshoot >= firerate)
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
                if (Input.GetKeyDown(KeyCode.R) && nrBulletsTotal > 0 && nrbullets != 40)
                {
                    if (nrBulletsTotal < 40 && nrBulletsTotal > 0 && nrBulletsTotal + nrbullets <= 40)
                    {
                        nrBulletsTotal = nrBulletsTotal + nrbullets;
                        nrbullets = nrBulletsTotal;
                        nrBulletsTotal = 0;
                    }

                    else
                    {
                        nrBulletsTotal = nrBulletsTotal + nrbullets;
                        nrBulletsTotal = nrBulletsTotal - 40;
                        nrbullets = 40;

                    }

                }
                text_ammo.text = nrbullets + "/" + nrBulletsTotal;
            }
        }


        if(AR)
        {
            firerate = 0.3f;
            if (Input.GetMouseButton(0) && nrbullets > 0 && nrBulletsTotal >= 0)
            {
                if (Time.time - timetoshoot >= firerate)
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
                if (Input.GetKeyDown(KeyCode.R) && nrBulletsTotal > 0 && nrbullets != 30)
                {
                    if (nrBulletsTotal < 30 && nrBulletsTotal > 0 && nrBulletsTotal + nrbullets <= 30)
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
    }



    void Shoot()
    {
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }
}
