﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public Vector3 speed = new Vector3(0, 0, 0);
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += speed * Time.deltaTime;
    }
}
