﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveracket : MonoBehaviour
{
    public float speed = 5;
    public string axis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxisRaw(axis) * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);
    }
}
