﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateObject : MonoBehaviour {
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rotate();
    }
    void Rotate() {
        transform.Rotate(Vector3.up* Time.deltaTime*speed);
    }
}
