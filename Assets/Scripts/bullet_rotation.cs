﻿using UnityEngine;
using System.Collections;

public class bullet_rotation : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(new Vector3(0, 0, 360) * Time.deltaTime);
    }
}
