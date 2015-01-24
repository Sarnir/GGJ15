using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour
{
	const float slowmoScale = 0.1f;
	const float normalScale = 2.0f;
	const float shiftSpeed = 2.0f;
	bool slowDown;
	float lerpProgress;

	void Start ()
	{
		Screen.lockCursor = false;

		Time.timeScale = normalScale;
		lerpProgress = 1.0f;
		slowDown = false;	}
	
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

		if (Input.GetKeyDown(KeyCode.Space))
		{
			slowDown = !slowDown;
		}

		if(slowDown)
			lerpProgress -= Time.deltaTime * shiftSpeed;
		else
			lerpProgress += Time.deltaTime * shiftSpeed;

		lerpProgress = Mathf.Clamp(lerpProgress, 0.0f, 1.0f);

		Time.timeScale = Mathf.Lerp(slowmoScale, normalScale, lerpProgress);
    }
}
