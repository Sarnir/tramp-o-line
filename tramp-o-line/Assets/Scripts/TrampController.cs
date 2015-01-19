using UnityEngine;
using System.Collections;
using System;

public class TrampController : MonoBehaviour {

    public DateTime SpaceUp {get; set; }
    public DateTime SpaceDown {get; set; }
	public DateTime TimeSpacePressed { get; set; }
    public int horizontalSpeed;
    public int rotationSpeed;
    public Transform spawnPoint;

	Trick currentTrick { get; set; }

	// Use this for initialization
	void Start () {
        Reset();
	}

    private void Reset()
    {
        transform.position = spawnPoint.position;
        transform.rotation = spawnPoint.rotation;
        rigidbody2D.velocity = Vector2.zero;
        rigidbody2D.angularVelocity = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
        var currentSpeed = rigidbody2D.velocity;
        var currentRotationSpeed = rigidbody2D.angularVelocity;

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

        if (Input.GetKey(KeyCode.UpArrow) && currentRotationSpeed < rotationSpeed * 80)
        {
            print("up arrow");
            rigidbody2D.AddTorque(rotationSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow) && currentRotationSpeed > -rotationSpeed * 80)
        {
            print("down arrow");
            rigidbody2D.AddTorque(-rotationSpeed);
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

    void OnTriggerEnter2D(Collider2D collider)
    {
        print("Collided with " + collider.gameObject.name + ", tag: " + collider.gameObject.tag);
        if (collider.gameObject.tag == "Spikes")
            Reset();
    }

    private void SetTrick<Tricktype>() where Tricktype : Component
    {
        gameObject.AddComponent<Tricktype>();
        currentTrick = gameObject.GetComponent<Trick>();
        currentTrick.SetPlayer(gameObject);
    }
}
