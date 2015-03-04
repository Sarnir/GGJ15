using UnityEngine;
using System.Collections;

public class GameOverHandler : MonoBehaviour
{
	void Update ()
	{
		if (Input.GetKey(KeyCode.Return))
		{
			Screen.lockCursor = false;
			Application.LoadLevel(PlayerPrefs.GetInt("LastLevel"));
		}
		else if (Input.GetKey(KeyCode.Escape))
		{
			Screen.lockCursor = false;
			Application.LoadLevel("menu");
		}
	}
}