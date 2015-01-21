using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour
{
	public GameObject sky1;
	public GameObject sky2;
	
	private Vector2 sky1Pos;
	private Vector2 sky2Pos;
	
	private float leftBoundary = -10.0f;
	private float rightBoundary = 11.0f;

	void Start ()
	{
		sky1Pos = new Vector2(rightBoundary, 0.0f);
		sky2Pos = new Vector2(leftBoundary, 0.0f);
	}

	void Update ()
	{
		ChangePosition(sky1Pos);
		ChangePosition(sky2Pos);
		sky1.transform.position = sky1Pos;
		sky2.transform.position = sky2Pos;
	}

	public void ChangePosition(Vector2 position)
	{
		if (position.x <= leftBoundary)
		{
			position = new Vector2(rightBoundary, 0.0f);
		}
		else
		{
			position = new Vector2(position.x - 0.5f, 0.0f);
		}
	}
}
