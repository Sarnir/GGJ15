using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class balloonHandler : MonoBehaviour
{
	[SerializeField()]
	GameObject balloonPop = null;

	SpriteRenderer spriteRenderer;

	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void Update ()
	{
	}

	void OnMouseDown()
	{
		spriteRenderer.sprite = balloonPop.GetComponent<SpriteRenderer>().sprite;
		collider2D.enabled = false;
		Destroy (gameObject, 0.1f);
	}
}
