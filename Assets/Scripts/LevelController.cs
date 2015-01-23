using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour
{
	public GameObject obiekt;

	void Start ()
	{
	}
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Return))
		{
			Application.LoadLevel("level2");
		}
	}
}
