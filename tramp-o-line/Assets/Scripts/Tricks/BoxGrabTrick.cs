using UnityEngine;
using System.Collections;

public class BoxGrabTrick : Trick {

    float startScaleX;
    bool returnAnimStarted;
    float animTime;
    float currentTime;
    float endLerpValue;
    float startLerpValue;

	// Use this for initialization
	void Start () {
        startScaleX = gameObject.transform.localScale.x;
        returnAnimStarted = false;
        animTime = 0.5f;
        currentTime = 0.0f;
        startLerpValue = startScaleX;
        endLerpValue = startScaleX * 2.0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        var scaleX = Mathf.Lerp(startLerpValue, endLerpValue, currentTime / animTime);

        gameObject.transform.localScale = new Vector3(scaleX, gameObject.transform.localScale.y);
        currentTime += Time.deltaTime;

        if (!returnAnimStarted && !Input.GetKey(KeyCode.B))
        {
            returnAnimStarted = true;
            currentTime = 0.0f;
            startLerpValue = scaleX;
            endLerpValue = startScaleX;
        }

        if (returnAnimStarted && currentTime >= animTime)
        {
            trickFinished = true;
        }
	}

    void OnDestroy()
    {
        gameObject.transform.localScale = new Vector3(startScaleX, gameObject.transform.localScale.y);
    }
}
