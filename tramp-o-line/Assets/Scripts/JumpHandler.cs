using UnityEngine;
using System.Collections;
using System;

public class JumpHandler : MonoBehaviour
{
	public GameObject hobo;

	private float ySpeed;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

    void OnCollisionEnter2D(Collision2D collision)
	{
		DateTime spaceDownTime = collision.gameObject.GetComponent<TrampController>().SpaceDown;
		DateTime spaceUpTime = collision.gameObject.GetComponent<TrampController>().SpaceUp;
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
		
		print ("POWER: " + power);
		collision.gameObject.rigidbody2D.AddForce(new Vector2(0, power));
        collision.gameObject.GetComponent<TrampController>().SpaceDown = DateTime.MinValue;
        collision.gameObject.GetComponent<TrampController>().SpaceUp = DateTime.MinValue;
    }
}
