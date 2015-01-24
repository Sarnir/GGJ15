using UnityEngine;
using System.Collections;

public class ClickableController : MonoBehaviour
{
	public Sprite button_on;
	public Sprite button_off;
	private SpriteRenderer sr;

	void Start ()
	{
		sr = GetComponent<SpriteRenderer>();
	}

	void Update ()
	{
	
	}

	void OnMouseDown()
	{
		sr.sprite = button_on;
	}

	void OnMouseUp()
	{
		sr.sprite = button_off;
	}
}
