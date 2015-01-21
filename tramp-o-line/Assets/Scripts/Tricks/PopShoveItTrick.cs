using UnityEngine;
using System.Collections;

public class PopShoveItTrick : Trick
{
	private bool firstHalf;
    private int trampScale = 5;

	void Start ()
	{
		firstHalf = true;
	}
	
	void Update()
	{
		float interval = trampScale / 10.0f;

		if (firstHalf)
		{
            if (gameObject.transform.localScale.x > -trampScale)
			{
                gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x - interval, gameObject.transform.localScale.y);
			}
			else
			{
				firstHalf = false;
			}
		}
		else
		{
            if (gameObject.transform.localScale.x < 5)
			{
                gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + interval, gameObject.transform.localScale.y);
			}
			else
			{
				trickFinished = true;
			}
		}
	}

    void OnDestroy()
    {
        gameObject.transform.localScale = new Vector3(5, gameObject.transform.localScale.y);
    }
}