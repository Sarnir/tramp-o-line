using UnityEngine;
using System.Collections;

public class PopShoveItTrick : Trick {
	
	public float startScale { get; set; }
	
	public override void SetPlayer(GameObject pl)
	{
		base.SetPlayer(pl);
		startScale = pl.transform.localScale.x;
		print("base scale " + startScale);
		PerformTrick();
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	void PerformTrick()
	{
		//player.rigidbody2D.transform.TransformPoint = new Vector3(-startScale, 0, 0);
	}
	
	void Update()
	{
		if (!trickFinished)
		{
			trickFinished = true;
		}
	}
}