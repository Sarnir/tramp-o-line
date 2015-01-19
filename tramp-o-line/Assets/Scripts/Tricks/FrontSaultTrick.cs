using UnityEngine;
using System.Collections;

public class FrontSaultTrick : Trick {

    public float startRotation { get; set; }

    public override void SetPlayer(GameObject pl)
    {
        base.SetPlayer(pl);
        startRotation = pl.transform.rotation.eulerAngles.z;
        print("base rotation " + startRotation);
        PerformTrick();
    }

	// Use this for initialization
	void Start () {
	
	}

    void PerformTrick()
    {
        player.rigidbody2D.AddTorque(100.0f);
    }

    void Update()
    {
        if (!trickFinished)
        {
            if (player && player.transform.rotation.eulerAngles.z - 360.0f > startRotation)
            {
                trickFinished = true;
                player.rigidbody2D.angularVelocity = 0.0f;
                print("doneeeeeee");
            }
        }
    }
}
