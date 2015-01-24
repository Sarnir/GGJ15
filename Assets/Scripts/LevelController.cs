using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour
{
	public GameObject levelClearPrefab;

	private GameObject levelClear;
	private int lastLevel = 11;
	const float slowmoScale = 0.1f;
	const float normalScale = 1.0f;
	const float shiftSpeed = 2.0f;
	bool slowDown;
	float lerpProgress;
	bool levelCleared;

	void Start ()
	{
		levelClear = Instantiate(levelClearPrefab) as GameObject;
		levelClear.SetActive(false);
		Screen.lockCursor = false;

		Time.timeScale = normalScale;
		lerpProgress = 0.5f;
		slowDown = true;
		levelCleared = false;

		StartCoroutine(CheckIfLevelCleared());
	}

	IEnumerator CheckIfLevelCleared()
	{
		Rigidbody2D[] physicObjects = FindObjectsOfType(typeof(Rigidbody2D)) as Rigidbody2D[];
		
		while(!levelCleared)
		{
			while(Screen.lockCursor)
			{
				yield return null;
			}
		
			levelCleared = true;

			foreach (Rigidbody2D physicObject in physicObjects) 
			{
				if(physicObject && !physicObject.IsSleeping())
				{
					levelCleared = false;
					yield return null;
					break;
				}
			}
		}
	}
	
	void Update ()
	{
		if (levelCleared)
		{
			levelClear.SetActive(true);
		}
		if (levelCleared && Input.GetKey(KeyCode.Return))
		{
			if (Application.loadedLevel == lastLevel)
				Application.LoadLevel("endGame");
			else
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

		lerpProgress = Mathf.Clamp01(lerpProgress);

		Time.timeScale = Mathf.Lerp(slowmoScale, normalScale, lerpProgress);
    }
}
