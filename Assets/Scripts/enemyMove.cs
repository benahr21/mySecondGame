﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float moveSpeed = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.Translate(Vector3.right *Time.deltaTime *moveSpeed);
        

    }
}
