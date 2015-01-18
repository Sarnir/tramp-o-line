using UnityEngine;
using System.Collections;
using System;

public class TrampController : MonoBehaviour {

    public DateTime SpaceUp {get; set; }
    public DateTime SpaceDown {get; set; }
	public DateTime TimeSpacePressed { get; set; }
    public int horizontalSpeed;

	Trick currentTrick { get; set; }

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        var currentSpeed = rigidbody2D.velocity;

        if (Input.GetKeyDown(KeyCode.C))
        {
            print("C pressed");
            SetTrick<FrontSaultTrick>();
        }

        if (Input.GetKey(KeyCode.RightArrow) && currentSpeed.x < horizontalSpeed * 4)
        {
            print("right arrow");
            rigidbody2D.AddForce(new Vector2(horizontalSpeed, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow) && currentSpeed.x > -horizontalSpeed * 4)
        {
            print("left arrow");
            rigidbody2D.AddForce(new Vector2(-horizontalSpeed, 0));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpaceDown = DateTime.Now;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            SpaceUp = DateTime.Now;
        }

        if (currentTrick && currentTrick.IsTrickFinished())
        {
            print("Trick finished!");
            Destroy(currentTrick);
            currentTrick = null;
        }
	}

    private void SetTrick<Tricktype>() where Tricktype : Component
    {
        gameObject.AddComponent<Tricktype>();
        currentTrick = gameObject.GetComponent<Trick>();
        currentTrick.SetPlayer(gameObject);
    }
}
