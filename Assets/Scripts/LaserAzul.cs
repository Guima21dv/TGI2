﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAzul : MonoBehaviour
{
    public float timer = 0.0f;
    public float waitingTime = 1.2f;
    public GameObject laserVerde;
    void Start()
    {
       
    }
    void Update()
    {
        
        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            laserVerde.SetActive(true);
            gameObject.SetActive(false);
            timer = 0f;
        }
    }  
}