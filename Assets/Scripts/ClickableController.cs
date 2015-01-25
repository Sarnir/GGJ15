using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class ClickableController : MonoBehaviour
{
	public Sprite button_on;
	public Sprite button_off;
	
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
		spriteRenderer.sprite = button_on;
	}

	void OnMouseUp()
	{
		spriteRenderer.sprite = button_off;
	}
}
