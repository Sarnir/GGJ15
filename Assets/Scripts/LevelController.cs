using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour
{
	public GameObject levelClearPrefab;
	public GameObject felineEye;

	private GameObject levelClear;
	private int lastLevel = 14;
	const float slowmoScale = 0.1f;
	const float normalScale = 1.0f;
	const float shiftSpeed = 2.0f;
	bool felineModeOn;
	float lerpProgress;
	bool levelCleared;

	FelineButtonHandler felineButtonHandler;

	void Start ()
	{
		levelClear = Instantiate(levelClearPrefab) as GameObject;
		levelClear.SetActive(false);
		Screen.lockCursor = false;

		Time.timeScale = normalScale;
		lerpProgress = 0.5f;
		felineModeOn = true;
		levelCleared = false;

		felineButtonHandler = felineEye.GetComponent<FelineButtonHandler>();
		felineButtonHandler.setFelineMode(felineModeOn);

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

	void ToggleFelineMode()
	{
		felineModeOn = !felineModeOn;
		felineButtonHandler.setFelineMode(felineModeOn);
	}
	
	void Update ()
	{
		if (levelCleared)
		{
			levelClear.SetActive(true);
		}
		if ((levelCleared && Input.GetKey(KeyCode.Return)) || Input.GetKey(KeyCode.F))
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
			ToggleFelineMode();
		}

		felineModeOn = felineButtonHandler.IsFelineMode();

		if(felineModeOn)
			lerpProgress -= Time.fixedDeltaTime * shiftSpeed;
		else
			lerpProgress += Time.fixedDeltaTime * shiftSpeed;

		lerpProgress = Mathf.Clamp01(lerpProgress);

		Time.timeScale = Mathf.Lerp(slowmoScale, normalScale, lerpProgress);
    }
}
