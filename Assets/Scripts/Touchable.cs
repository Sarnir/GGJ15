using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Touchable : MonoBehaviour {

	bool isTouched;

	[SerializeField()]
	float moveSpeed = 100.0f;

	// Use this for initialization
	void Start () {
		isTouched = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(isTouched)
		{
			Vector2 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			var objectPos = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
			rigidbody2D.MovePosition(objectPos);
		}
	}

	void OnMouseDown()
	{
		isTouched = true;
		rigidbody2D.gravityScale = 0.0f;
		rigidbody2D.velocity = Vector2.zero;
		rigidbody2D.angularVelocity = 0.0f;
	}

	void OnMouseUp()
	{
		isTouched = false;
		rigidbody2D.gravityScale = 1.0f;
	}
}
