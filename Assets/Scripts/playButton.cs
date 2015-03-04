using UnityEngine;
using System.Collections;

public class playButton : MonoBehaviour
{
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
