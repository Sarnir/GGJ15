using UnityEngine;
using System.Collections;

public class HighlightWhenMouseOver : MonoBehaviour {

	bool isMouseOver;
	bool isTouched;

	Touchable touchableScript;

	// Use this for initialization
	void Start () {
		isMouseOver = false;

		touchableScript = GetComponent<Touchable>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(touchableScript)
			isTouched = touchableScript.IsTouched();

		SetHighlighted(isTouched || isMouseOver);
	}

	void SetHighlighted(bool highlight)
	{
		if(highlight)
		{
			renderer.material.color = Color.gray;
		}
		else
			renderer.material.color = Color.white;
	}

	
	void OnMouseEnter()
	{
		isMouseOver = true;
	}
	
	void OnMouseExit()
	{
		isMouseOver = false;
	}
}
