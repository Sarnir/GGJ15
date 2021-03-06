﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(HighlightWhenMouseOver))]
public class Touchable : MonoBehaviour
{
	bool isTouched;
	[SerializeField()]
	GameObject cursorSpritePrefab = null;
	GameObject cursorSprite;
	[SerializeField()]
	float touchForce = 1.0f;

	void Start()
	{
		isTouched = false;
		cursorSprite = Instantiate(cursorSpritePrefab) as GameObject;
		cursorSprite.SetActive(false);
	}

	public bool IsTouched()
	{
		return isTouched;
	}

	void FixedUpdate()
	{
		if (isTouched)
		{
			var timeFactor = Time.fixedDeltaTime;
			var force = new Vector2(Input.GetAxis ("Mouse X") / timeFactor, Input.GetAxis ("Mouse Y") / timeFactor);
			force /= Time.timeScale;
			force *= touchForce;
			rigidbody2D.AddForce(force);
		}
	}

	void Update()
	{
		if (isTouched)
		{
			cursorSprite.transform.position = transform.position;
		}
	}

	Vector2 GetMousePosition()
	{
		return Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}

	void OnMouseDown()
	{
		cursorSprite.SetActive(true);
		Screen.lockCursor = true;
		isTouched = true;
		rigidbody2D.gravityScale = 0.0f;
		rigidbody2D.velocity = Vector2.zero;
		rigidbody2D.angularVelocity = 0.0f;
	}

	void OnMouseUp()
	{
		cursorSprite.SetActive (false);
		Screen.lockCursor = false;
		isTouched = false;
		rigidbody2D.gravityScale = 1.0f;
	}
}