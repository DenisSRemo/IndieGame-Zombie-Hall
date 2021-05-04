using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    //health for a type on zombie
    [SerializeField] private Zombie zombie;
    private Vector3 localSc;
    // Start is called before the first frame update
    void Start()
    {
        localSc = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        localSc.x = zombie.health / 10;
        transform.localScale = localSc;
    }
}
