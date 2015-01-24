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
			Application.LoadLevel(0);
		}
	}
}
