using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Touchable : MonoBehaviour {

	float moveSpeed = 100.0f;
	bool isTouched;

	// Use this for initialization
	void Start ()
	{
		isTouched = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(isTouched)
		{
			var force = new Vector2(Input.GetAxis("Mouse X") / Time.deltaTime, Input.GetAxis("Mouse Y") / Time.deltaTime);
			rigidbody2D.AddForce(force);
		}
	}

	Vector2 GetMousePosition()
	{
		return Camera.main.ScreenToWorldPoint (Input.mousePosition);
	}

	void OnMouseDown()
	{
		Screen.lockCursor = true;
		isTouched = true;
		rigidbody2D.gravityScale = 0.0f;
		rigidbody2D.velocity = Vector2.zero;
		rigidbody2D.angularVelocity = 0.0f;
	}

	void OnMouseUp()
	{
		Screen.lockCursor = false;
		isTouched = false;
		rigidbody2D.gravityScale = 1.0f;
	}
}
