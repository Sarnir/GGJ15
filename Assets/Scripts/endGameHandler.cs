using UnityEngine;
using System.Collections;

public class endGameHandler : MonoBehaviour
{
	void Start ()
	{
		
	}

	void Update ()
	{
		if (Input.GetKey(KeyCode.Return))
		{
			Application.LoadLevel ("menu");
		}
	}
}
