﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    // This is the speed of the racket

    public float speed = 30;
    public string axis;
    void FixedUpdate()
    {
        //This our GetAxisRaw input
        float V = Input.GetAxisRaw(axis) * speed;
   //Just calling the Rigidbody2D component to change its Velocity value
    GetComponent<Rigidbody2D>().velocity = new Vector2(0,V);

    }
}
