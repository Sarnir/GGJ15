using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class balloonHandler : MonoBehaviour
{
	[SerializeField()]
	GameObject balloonPop = null;
	SpriteRenderer spriteRenderer;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	void OnMouseDown()
	{
		PopBalloon();
	}

	void PopBalloon()
	{
		spriteRenderer.sprite = balloonPop.GetComponent<SpriteRenderer>().sprite;
		collider2D.enabled = false;
		Destroy(gameObject, 0.1f);
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "obstacle")
		{
			PopBalloon();
		}
	}
}