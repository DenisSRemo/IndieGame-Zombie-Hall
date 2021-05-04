using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusOneBullet : MonoBehaviour
{
    // Start is called before the first frame update

   // [SerializeField] private weapon weapon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlusOneBulletFunction(weapon weapon)
    {
        weapon.nrBulletsTotal++;
    }
}
