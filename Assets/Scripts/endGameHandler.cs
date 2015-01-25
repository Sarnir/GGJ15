using UnityEngine;
using System.Collections;

public class endGameHandler : MonoBehaviour
{
	void Start ()
	{
		Time.timeScale = 1.0f;
	}

	void Update ()
	{
		if (Input.GetKey(KeyCode.Return))
		{
			Application.LoadLevel ("menu");
		}
	}
}
