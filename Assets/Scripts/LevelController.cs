﻿using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour
{
	void Start ()
	{
	}
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Return))
		{
			Application.LoadLevel(Application.loadedLevel + 1);
		}
    }
}
