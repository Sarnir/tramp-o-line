using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour
{
	public GameObject play;
	public GameObject credits;
	public GameObject exit;
	public Camera camera;

	private int lmb;

	void Start ()
	{
		lmb = 0;
	}
	
	void Update ()
	{
		if (Input.GetMouseButtonUp(lmb))
		{
			float mouseX = camera.ScreenToWorldPoint(Input.mousePosition).x;
			float mouseY = camera.ScreenToWorldPoint(Input.mousePosition).y;
			if (Physics2D.Raycast(new Vector2(mouseX, mouseY), new Vector2(play.transform.position.x, play.transform.position.y), 0.1f))
			{
				print ("play");
			}
			else if (Physics2D.Raycast(new Vector2(mouseX, mouseY), new Vector2(credits.transform.position.x, credits.transform.position.y), 0.1f))
			{
				print ("credits");
			}
			else if (Physics2D.Raycast(new Vector2(mouseX, mouseY), new Vector2(exit.transform.position.x, exit.transform.position.y), 0.1f))
			{
				print ("exit");
			}
		}
	}
}
