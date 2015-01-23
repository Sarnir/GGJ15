using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour
{
	public new Camera camera;

	void Start ()
	{
		if (Application.loadedLevel == 0)
		{

		}
		else if (Application.loadedLevel == 1)
		{
		}
		else if (Application.loadedLevel == 2)
		{
		}
	}
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Return))
		{
			Application.LoadLevel(Application.loadedLevel + 1);
		}
	}
}
