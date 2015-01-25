using UnityEngine;
using System.Collections;

public class buttonHandler : MonoBehaviour
{
	public GameObject toMove;
	public float moveX;
	public float moveY;

	private bool pressed;
	private float oldPosX;
	private float oldPosY;

	void Start ()
	{
		pressed = false;
	}

	void Update ()
	{
	}

	void OnMouseDown()
	{
		if (pressed)
		{
			float newX = toMove.transform.position.x - moveX;
			float newY = toMove.transform.position.y - moveY;
			toMove.transform.position = new Vector2(newX, newY);
			pressed = false;
		}
		else
		{
			float newX = toMove.transform.position.x + moveX;
			float newY = toMove.transform.position.y + moveY;
			toMove.transform.position = new Vector2(newX, newY);
			pressed = true;
		}
	}
}
