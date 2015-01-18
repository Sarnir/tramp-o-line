using UnityEngine;
using System.Collections;
using System;

public class TrampController : MonoBehaviour {
	
	public DateTime SpaceUp { get; set; }
	public DateTime SpaceDown { get; set; }
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("right arrow");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("left arrow");
		}
		
		if (Input.GetKeyDown(KeyCode.Space)) // zdobądź klucz dałnie
		{
			SpaceDown = DateTime.Now;
		}
		
		if (Input.GetKeyUp(KeyCode.Space))
		{
			SpaceUp = DateTime.Now;
		}
	}
}
