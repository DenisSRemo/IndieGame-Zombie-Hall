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

    //due to the fact there is a bug which makes the character shot the gun after the player presses a button on the UI

    public void PlusOneBulletFunction(weapon weapon)
    {
        weapon.nrBulletsTotal++;
    }
}
