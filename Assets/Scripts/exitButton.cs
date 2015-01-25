using UnityEngine;
using System.Collections;

public class exitButton : MonoBehaviour
{
	void Start ()
	{
	}

	void Update ()
	{
	}

	void OnMouseUp()
	{
		Application.Quit();
	}

	void OnMouseHover()
	{
		audio.Play();
	}
}
