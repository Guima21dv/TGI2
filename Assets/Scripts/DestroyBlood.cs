﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlood : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Destroy(gameObject, 2f);
    }
}
