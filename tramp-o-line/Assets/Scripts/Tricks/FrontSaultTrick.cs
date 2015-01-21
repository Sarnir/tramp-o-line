using UnityEngine;
using System.Collections;

public class FrontSaultTrick : Trick {

    float deltaRotation { get; set; }
    float currentRotation { get; set; }
    float previousRotation { get; set; }

	// Use this for initialization
	void Start () {
        currentRotation = gameObject.transform.rotation.eulerAngles.z;
        deltaRotation = 0.0f;
        previousRotation = 0.0f;
        gameObject.rigidbody2D.AddTorque(100.0f);
	}

    void Update()
    {
        if (!trickFinished)
        {
            if (Mathf.Abs(deltaRotation) > 359.0f)
            {
                trickFinished = true;
                gameObject.rigidbody2D.angularVelocity = 0.0f;
                print("doneeeeeee");
            }

            previousRotation = currentRotation;
            currentRotation = gameObject.transform.rotation.eulerAngles.z;
            deltaRotation += currentRotation - previousRotation;
        }
    }
}
