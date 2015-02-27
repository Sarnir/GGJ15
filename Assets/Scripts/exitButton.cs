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
        PlayerPrefs.Save();
		Application.Quit();
	}

	void OnMouseHover()
	{
		audio.Play();
	}
}
