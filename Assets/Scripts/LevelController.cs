using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour
{
	public Camera camera;

	void Start ()
	{

	}
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Return))
		{
			Application.LoadLevel(Application.loadedLevel + 1);
		}



		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			camera.transform.position = new Vector3(
				camera.transform.position.x,
				camera.transform.position.y + 1,
				camera.transform.position.z);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			camera.transform.position = new Vector3(
				camera.transform.position.x,
				camera.transform.position.y - 1,
				camera.transform.position.z);
		}
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			camera.transform.position = new Vector3(
				camera.transform.position.x - 1,
				camera.transform.position.y,
				camera.transform.position.z);
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			camera.transform.position = new Vector3(
				camera.transform.position.x + 1,
				camera.transform.position.y,
                camera.transform.position.z);
		}
    }
}
