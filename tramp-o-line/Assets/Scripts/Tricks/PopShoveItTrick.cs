using UnityEngine;
using System.Collections;

public class PopShoveItTrick : Trick
{
	private bool firstHalf;

	public override void SetPlayer(GameObject pl)
	{
		base.SetPlayer(pl);
	}

	void Start ()
	{
		firstHalf = true;
	}
	
	void Update()
	{
		if (firstHalf)
		{
			if (player.transform.localScale.x > -5)
			{
				player.transform.localScale = new Vector3(player.transform.localScale.x - 0.5f, player.transform.localScale.y);
			}
			else
			{
				firstHalf = false;
			}
		}
		else
		{
			if (player.transform.localScale.x < 5)
			{
				player.transform.localScale = new Vector3(player.transform.localScale.x + 0.5f, player.transform.localScale.y);
			}
			else
			{
				trickFinished = true;
			}
		}
	}
}