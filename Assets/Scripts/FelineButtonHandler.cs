using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class FelineButtonHandler : MonoBehaviour
{
	[SerializeField()]
	Sprite WideEye = null;
	[SerializeField()]
	Sprite NarrowEye = null;
	SpriteRenderer spriteRenderer;
	bool isFelineMode;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	public bool IsFelineMode()
	{
		return isFelineMode;
	}

	public void setFelineMode (bool val)
	{
		isFelineMode = val;
	}

	void Update ()
	{
		if (isFelineMode)
		{
			spriteRenderer.sprite = NarrowEye;
		}
		else
		{
			spriteRenderer.sprite = WideEye;
		}
	}

	void OnMouseDown()
	{
		isFelineMode = !isFelineMode;
	}
}