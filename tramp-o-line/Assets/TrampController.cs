using UnityEngine;
using System.Collections;

public class TrampController : MonoBehaviour {

    public int horizontalSpeed;

    Trick currentTrick { get; set; }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var currentSpeed = rigidbody2D.velocity;

        if (Input.GetKeyDown(KeyCode.C))
            print("C pressed");

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
	}
}
