﻿using UnityEngine;
using System.Collections;

public class TrampController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("right arrow");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("left arrow");
        }
	}
}