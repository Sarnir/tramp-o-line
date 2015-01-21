using UnityEngine;
using System.Collections;

public class PopShoveItTrick : Trick
{
	private bool firstHalf;

	void Start ()
	{
		firstHalf = true;
	}
	
	void Update()
	{
		if (firstHalf)
		{
            if (gameObject.transform.localScale.x > -5)
			{
                gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x - 0.5f, gameObject.transform.localScale.y);
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
                gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + 0.5f, gameObject.transform.localScale.y);
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