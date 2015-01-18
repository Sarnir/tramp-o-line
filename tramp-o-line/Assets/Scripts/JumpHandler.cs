using UnityEngine;
using System.Collections;
using System;

public class JumpHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
	{
		DateTime spaceDown = collision.gameObject.GetComponent<TrampController>().SpaceDown;
		DateTime spaceUp = collision.gameObject.GetComponent<TrampController>().SpaceUp;

		int power = 200;

		if (spaceDown != DateTime.MinValue && spaceUp != DateTime.MinValue) // klik spacji
		{
			int miliseconds = (int)(DateTime.Now - spaceUp).TotalMilliseconds;
			if (miliseconds > 300) // spację puszczono dawno
			{
				power = 150; // za wcześnie puszczony
			}
			else // puszczono niedawno
			{
				power = 600 - miliseconds;
			}
			
			collision.gameObject.rigidbody2D.AddForce(new Vector2(0, power));
			collision.gameObject.GetComponent<TrampController> ().SpaceDown = DateTime.MinValue;
			collision.gameObject.GetComponent<TrampController> ().SpaceUp = DateTime.MinValue;
		}
		else if (spaceDown != DateTime.MinValue)
		{
			power = 200;
			
			collision.gameObject.rigidbody2D.AddForce(new Vector2(0, power));
			collision.gameObject.GetComponent<TrampController> ().SpaceDown = DateTime.MinValue;
			collision.gameObject.GetComponent<TrampController> ().SpaceUp = DateTime.MinValue;
		}
		else if (spaceUp != DateTime.MinValue)
		{
			power = 500;
			
			collision.gameObject.rigidbody2D.AddForce(new Vector2(0, power));
			collision.gameObject.GetComponent<TrampController> ().SpaceDown = DateTime.MinValue;
			collision.gameObject.GetComponent<TrampController> ().SpaceUp = DateTime.MinValue;
		}
		else
		{
			Vector2 newForce = collision.gameObject.rigidbody2D.velocity;
			
			
			collision.gameObject.rigidbody2D.AddForce(new Vector2(0, power));
			collision.gameObject.GetComponent<TrampController> ().SpaceDown = DateTime.MinValue;
			collision.gameObject.GetComponent<TrampController> ().SpaceUp = DateTime.MinValue;
		}
	
    }
}
