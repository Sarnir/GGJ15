using UnityEngine;
using System.Collections;

public class CatController : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag != "catIgnore")
		{
			PlayerPrefs.SetInt ("LastLevel", Application.loadedLevel);
			Application.LoadLevel ("gameOver");
		}
	}
}