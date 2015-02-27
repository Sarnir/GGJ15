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
        PlayerPrefs.Save();
		Application.LoadLevel(1);
	}
	
	void OnMouseHover()
	{
		audio.Play();
	}
}
