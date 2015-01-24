using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class ClickableController : MonoBehaviour
{
	public Sprite button_on;
	public Sprite button_off;
	public GameObject stringOwner;
	
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
		Destroy(stringOwner.GetComponent<DistanceJoint2D>());
	}

	void OnMouseUp()
	{
		spriteRenderer.sprite = button_off;
	}
}
