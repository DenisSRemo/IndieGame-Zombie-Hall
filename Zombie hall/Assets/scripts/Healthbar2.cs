﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar2 : MonoBehaviour
{
    [SerializeField] private Zombie2 zombie;
    private Vector3 localSc;
    // Start is called before the first frame update
    void Start()
    {
        localSc = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        localSc.x = zombie.health / 100;
        transform.localScale = localSc;
    }
}
