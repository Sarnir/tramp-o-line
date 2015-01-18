using UnityEngine;
using System.Collections;

public class JumpHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("collided!");

        collision.gameObject.rigidbody2D.AddForce(new Vector2(0, 500));
    }
}
