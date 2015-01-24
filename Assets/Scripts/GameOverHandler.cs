using UnityEngine;
using System.Collections;

public class GameOverHandler : MonoBehaviour
{
	void Start ()
	{
	
	}
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Return))
		{
			Screen.lockCursor = false;
			Application.LoadLevel(PlayerPrefs.GetInt("LastLevel"));
		}
		else if (Input.GetKey(KeyCode.Return))
		{
			Screen.lockCursor = false;
			Application.LoadLevel(PlayerPrefs.GetInt("menu"));
		}
	}
}
