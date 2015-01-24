using UnityEngine;
using System.Collections;

public class ClickableController : MonoBehaviour
{
	public Sprite button_on;
	public Sprite button_off;
	public GameObject stringOwner;

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
		Destroy(stringOwner.GetComponent<DistanceJoint2D>());
	}

	void OnMouseUp()
	{
		sr.sprite = button_off;
	}
}
