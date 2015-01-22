using UnityEngine;
using System.Collections;

public class SkyController : MonoBehaviour
{
	public float scrollSpeed;

	private float tileSizeX;

	private Vector3 startPosition;

	void Start ()
	{
		tileSizeX = renderer.bounds.size.x;
		startPosition = transform.position;
	}

	void Update ()
	{
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeX);
		transform.position = startPosition + Vector3.left * newPosition;
	}
}
