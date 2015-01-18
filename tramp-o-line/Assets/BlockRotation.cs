using UnityEngine;
using System.Collections;

public class BlockRotation : MonoBehaviour {

	public GameObject tramp;

	void Start () {
	
	}

	void Update ()
	{
		gameObject.transform.position =
			new Vector3(tramp.transform.position.x, tramp.transform.position.y,
			            gameObject.transform.position.z);
	}
}
