using UnityEngine;
using System.Collections;
using System;

public class JumpHandler : MonoBehaviour
{
    DateTime SpaceUp;
    DateTime SpaceDown;

	private float ySpeed;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpaceDown = DateTime.Now;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            SpaceUp = DateTime.Now;
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
	{
		DateTime spaceDownTime = SpaceDown;
		DateTime spaceUpTime = SpaceUp;
		float power = 500;

		double spaceDown = (DateTime.Now - spaceDownTime).TotalMilliseconds; // max 1000
		double spaceUp = (DateTime.Now - spaceUpTime).TotalMilliseconds; // max 300, optimum 100

		if (spaceDownTime != DateTime.MinValue && spaceUpTime != DateTime.MinValue)
		{
			if (spaceDown < 300)
			{
				power += (float)spaceDown;
			}
			if (spaceUp < 300)
			{
				power += 500 - (float)spaceUp;
			}
		}
		
		//print ("POWER: " + power);
		collision.gameObject.rigidbody2D.AddForce(new Vector2(0, power));
        SpaceDown = DateTime.MinValue;
        SpaceUp = DateTime.MinValue;
    }
}
