using UnityEngine;
using System.Collections;

public class CatController : MonoBehaviour
{
	private int catIgnoreLayer = 8;

	void Start ()
	{
	}

	void Update ()
	{
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.layer != catIgnoreLayer)
		{
			PlayerPrefs.SetInt ("LastLevel", Application.loadedLevel);
			Application.LoadLevel ("gameOver");
		}
	}
}
