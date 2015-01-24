using UnityEngine;
using System.Collections;

public class CatController : MonoBehaviour
{
	void Start ()
	{
		print ("MYAAA!!! SEE????");
	}

	void Update ()
	{
		
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.layer != 8)
		{
			Application.LoadLevel ("gameOver");
		}
	}
}
