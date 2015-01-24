using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour
{
	const float slowmoScale = 0.1f;
	const float normalScale = 1.0f;
	const float shiftSpeed = 2.0f;
	bool slowDown;
	float lerpProgress;

	void Start ()
	{
		Screen.lockCursor = false;

		Time.timeScale = normalScale;
		lerpProgress = 0.5f;
		slowDown = true;	
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

		if (Input.GetKeyDown(KeyCode.Space))
		{
			slowDown = !slowDown;
		}

		if(slowDown)
			lerpProgress -= Time.fixedDeltaTime * shiftSpeed;
		else
			lerpProgress += Time.fixedDeltaTime * shiftSpeed;

		lerpProgress = Mathf.Clamp(lerpProgress, 0.0f, 1.0f);

		Time.timeScale = Mathf.Lerp(slowmoScale, normalScale, lerpProgress);
    }
}
