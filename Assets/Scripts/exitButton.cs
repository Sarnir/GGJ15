using UnityEngine;
using System.Collections;

public class exitButton : MonoBehaviour
{
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
