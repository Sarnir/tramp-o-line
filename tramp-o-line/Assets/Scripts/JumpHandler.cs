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
		DateTime space = collision.gameObject.GetComponent<TrampController>().TimeSpacePressed;
		DateTime touch = DateTime.Now;
		TimeSpan ts = touch - space;
		print(ts.Milliseconds);

        collision.gameObject.rigidbody2D.AddForce(new Vector2(0, 500));

    }
}
