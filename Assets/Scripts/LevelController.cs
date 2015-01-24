using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour
{
	void Start ()
	{
		Screen.lockCursor = false;
	}
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Return))
		{
			Application.LoadLevel(Application.loadedLevel + 1);
		}
		else if (Input.GetKey(KeyCode.Escape))
		{
			Application.LoadLevel("menu");
		}
    }
}
