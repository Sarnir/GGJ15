using UnityEngine;
using System.Collections;

public class GameOverHandler : MonoBehaviour
{
	public int LevelId;

	void Start ()
	{
	
	}
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Return))
		{
			Screen.lockCursor = false;
			Application.LoadLevel(0);
		}
	}
}
