using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Touchable : MonoBehaviour {

	const float maxSpeed = 2000.0f;
	bool isTouched;

	// Use this for initialization
	void Start ()
	{
		isTouched = false;
	}

	public bool IsTouched()
	{
		return isTouched;
	}

	void FixedUpdate()
	{
		if(isTouched)
		{
			var timeFactor = Time.fixedDeltaTime;
			//var timeFactor = Time.unscaledDeltaTime;
			var force = new Vector2(Input.GetAxis("Mouse X") / timeFactor, Input.GetAxis("Mouse Y") / timeFactor);
			force /= Time.timeScale;
			rigidbody2D.AddForce(force);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
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
