using UnityEngine;
using System.Collections;

public class CatController : MonoBehaviour
{
	private int catIgnoreLayer = 8;

	void Start ()
	{
		print ("MYAAA!!! SEE????");
	}

	void Update ()
	{
		
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.layer != catIgnoreLayer)
		{
			Application.LoadLevel ("gameOver");
		}
	}
}
