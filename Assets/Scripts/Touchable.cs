using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Touchable : MonoBehaviour {

	const float maxSpeed = 20.0f;
	bool isTouched;
	bool isMouseOver;

	// Use this for initialization
	void Start ()
	{
		isTouched = false;
		isMouseOver = false;
	}

	void FixedUpdate()
	{
		if(isTouched)
		{
			var timeFactor = Time.unscaledDeltaTime;
			var force = new Vector2(Input.GetAxis("Mouse X") / timeFactor, Input.GetAxis("Mouse Y") / timeFactor);
			rigidbody2D.AddForce(force);
			Vector2 velocity = rigidbody2D.velocity;
			rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity, maxSpeed);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		SetHighlighted(isTouched || isMouseOver);
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

	void OnMouseEnter()
	{
		isMouseOver = true;
	}

	void OnMouseExit()
	{
		isMouseOver = false;
	}

	void SetHighlighted(bool highlight)
	{
		if(highlight)
		{
			renderer.material.color = Color.red;
		}
		else
			renderer.material.color = Color.white;
	}
}
