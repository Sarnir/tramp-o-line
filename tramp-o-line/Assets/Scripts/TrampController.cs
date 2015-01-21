using UnityEngine;
using System.Collections;
using System;

public class TrampController : MonoBehaviour
{
	public DateTime TimeSpacePressed { get; set; }
    public int horizontalSpeed;
    public int rotationSpeed;
    public Transform spawnPoint;

	// Use this for initialization
	void Start ()
	{
        Reset();
	}
	
	// Update is called once per frame
	void Update ()
	{
        Vector2 currentSpeed = rigidbody2D.velocity;
		float currentRotationSpeed = rigidbody2D.angularVelocity;

        if (Input.GetKey(KeyCode.RightArrow) && currentSpeed.x < horizontalSpeed * 4)
        {
            rigidbody2D.AddForce(new Vector2(horizontalSpeed, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow) && currentSpeed.x > -horizontalSpeed * 4)
        {
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
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        print("Collided with " + collider.gameObject.name + ", tag: " + collider.gameObject.tag);
        if (collider.gameObject.tag == "Spikes")
            Reset();
    }
	
	private void Reset()
	{
		transform.position = spawnPoint.position;
		transform.rotation = spawnPoint.rotation;
		rigidbody2D.velocity = Vector2.zero;
		rigidbody2D.angularVelocity = 0.0f;
	}
}
