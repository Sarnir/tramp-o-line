using UnityEngine;
using System.Collections;

public class TrickController : MonoBehaviour {

    Trick currentTrick;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            print("C pressed");
            SetTrick<PopShoveItTrick>();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            print("V pressed");
            // jeszcze nic
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            print("B pressed");
            SetTrick<BoxGrabTrick>();
        }

        if (currentTrick && currentTrick.IsTrickFinished())
        {
            EndTrickWithSuccess(true);
        }
	}

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (currentTrick)
            EndTrickWithSuccess(false);
    }

    private void SetTrick<Tricktype>() where Tricktype : Component
    {
        if (!currentTrick)
            currentTrick = gameObject.AddComponent<Tricktype>() as Trick;
    }

    void EndTrickWithSuccess(bool isSuccess)
    {
        if(isSuccess)
            print("Trick finished!");
        else
            print("Trick failed!");

        Destroy(currentTrick);
        currentTrick = null;
    }
}
