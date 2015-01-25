using UnityEngine;
using System.Collections;

public class playButton : MonoBehaviour
{
	void Start ()
	{
	}

	void Update ()
	{
	}

	void OnMouseUp()
	{
		Application.LoadLevel(1);
	}
	
	void OnMouseHover()
	{
		audio.Play();
	}
}
