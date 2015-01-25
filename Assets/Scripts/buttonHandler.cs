using UnityEngine;
using System.Collections;

public class buttonHandler : MonoBehaviour
{
	public GameObject toMove;
	public float moveX;
	public float moveY;

	void Start ()
	{
	}

	void Update ()
	{
	}

	void OnMouseDown()
	{
		float newX = toMove.transform.position.x + moveX;
		float newY = toMove.transform.position.y + moveY;
		toMove.transform.position = new Vector2(newX, newY);
	}
}
