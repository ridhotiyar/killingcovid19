﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomlymove : MonoBehaviour
{
    // Start is called before the first frame update
    // public float speed = 2;
    // public int time = 0;
    // public Rigidbody2D virus;

    // void Start()
    // {
    //     int x = Random.Range (-1, 1)*2-1;
    //     virus.velocity = new Vector2(x,0)*speed;
    // }
    public float accelerationTime = 2f;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;

    public Rigidbody2D rb;
    public float speed = 1;
     // Use this for initialization
    void Start ()
    {
         rb = GetComponent<Rigidbody2D> ();
    }
    
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }
    }
    
    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
    }  
}